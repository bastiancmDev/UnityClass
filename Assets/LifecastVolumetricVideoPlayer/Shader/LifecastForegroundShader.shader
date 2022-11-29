/*
The MIT License

Copyright © 2022 Lifecast Incorporated

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

Shader "LifecastForegroundShader"
{
    Properties
    {
        [NoScaleOffset] _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" }

        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            // vertex shader inputs
            struct appdata
            {
                float4 vertex : POSITION; // vertex position
                float2 uv : TEXCOORD0; // texture coordinate
            };

            // vertex shader outputs ("vertex to fragment")
            struct v2f
            {
                float2 uv : TEXCOORD0; // texture coordinate
                float4 vertex : SV_POSITION; // clip space position
                float vMaxD : TEXCOORD1;
            };

            // texture we will sample
            sampler2D _MainTex;

            // vertex shader
            v2f vert (appdata v)
            {
                v2f o;

                float2 depth_uv = float2(v.uv.x * 0.5 + 0.5, v.uv.y * 0.5 + 0.5);

                const float eps = 1.0 / (32.0 * 18.0);
                const float eps2 = eps * 2.0;

                float ds1 = tex2Dlod(_MainTex, float4(depth_uv + float2(-eps, 0.0), 0.0, 0.0)).r;
                float ds2 = tex2Dlod(_MainTex, float4(depth_uv + float2(eps, 0.0), 0.0, 0.0)).r;
                float ds3 = tex2Dlod(_MainTex, float4(depth_uv + float2(0.0, eps), 0.0, 0.0)).r;
                float ds4 = tex2Dlod(_MainTex, float4(depth_uv + float2(0.0, -eps), 0.0, 0.0)).r;

                float ds5 = tex2Dlod(_MainTex, float4(depth_uv + float2(-eps2, 0.0), 0.0, 0.0)).r;
                float ds6 = tex2Dlod(_MainTex, float4(depth_uv + float2(eps2, 0.0), 0.0, 0.0)).r;
                float ds7 = tex2Dlod(_MainTex, float4(depth_uv + float2(0.0, eps2), 0.0, 0.0)).r;
                float ds8 = tex2Dlod(_MainTex, float4(depth_uv + float2(0.0, -eps2), 0.0, 0.0)).r;

                float max_d =  ds1;
                max_d = max(max_d, ds2);
                max_d = max(max_d, ds3);
                max_d = max(max_d, ds4);

                float max_d2 =  ds5;
                max_d2 = max(max_d2, ds6);
                max_d2 = max(max_d2, ds7);
                max_d2 = max(max_d2, ds8);

                float s = clamp(0.3 / max_d, 0.01, 50.0);

                o.vertex = UnityObjectToClipPos(v.vertex * s);
                o.uv = v.uv;
                o.vMaxD = max_d2;

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 depth_uv   = float2(i.uv.x * 0.5 + 0.5, i.uv.y * 0.5 + 0.5);
                float2 texture_uv = float2(i.uv.x * 0.5      , i.uv.y * 0.5 + 0.5);

                float depth_sample = tex2D(_MainTex, depth_uv).r;
                float a = 1.0 - clamp(5.0 * (i.vMaxD - depth_sample), 0.0, 1.0);
                a = (tanh(a * 16.0 - 13.0) + 1.0) * 0.5;

                fixed3 rgb = tex2D(_MainTex, texture_uv).rgb;

                // Make it so we can't discard texels with zero gradient. This helps avoid
                // making holes in the vignette.
                float3 coefs = float3(0.299, 0.587, 0.114);
                float gray = dot(rgb, coefs);
                float delta = 4.0/4096.0;
                float dx = dot(tex2D(_MainTex, texture_uv + float2(delta, 0.0)).rgb, coefs) - gray;
                float dy = dot(tex2D(_MainTex, texture_uv + float2(0.0, delta)).rgb, coefs) - gray;
                float grad = dx * dx + dy * dy;

                if (grad == 0.0) a = 1.0;

                return fixed4(rgb, a);
            }
            ENDCG
        }
    }
}
