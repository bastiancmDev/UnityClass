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

using System;
using UnityEngine;

public class LifecastOrbitCamera : MonoBehaviour
{
    public GameObject target;

    public float camera_radius = 0.2f;
    public float rx = 0.0f;
    public float ry = 0.0f;
    public float tx = 0.0f;
    public float ty = 0.0f;

    void Start()
    {
        var angles = transform.eulerAngles;
        rx = angles.x;
        ry = angles.y;
    }

    void LateUpdate()
    {
        if (!target) return;
      
        camera_radius -= Input.GetAxis("Mouse ScrollWheel");
        camera_radius = Mathf.Clamp(camera_radius, 0.01f, 5.0f);

        if (Input.GetMouseButton(0))
        {
            ry += Input.GetAxis("Mouse X") * 8.0f;
            rx -= Input.GetAxis("Mouse Y") * 4.0f;
            rx = Mathf.Clamp(rx, -80.0f, 80.0f);
        }

        if (Input.GetMouseButton(1))
        {
            tx -= Input.GetAxis("Mouse X") * 0.02f;
            ty -= Input.GetAxis("Mouse Y") * 0.02f;
        }
        tx *= 0.99f;
        ty *= 0.99f;

        var rotation = Quaternion.Euler(rx, ry, 0);
        transform.rotation = rotation;
        transform.position = rotation * new Vector3(tx, ty, -camera_radius) + target.transform.position;
    }
}