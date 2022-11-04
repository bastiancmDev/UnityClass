using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UpdateUiHandler : MonoBehaviour
{

    public Text TitleText;
    public Text Damage;
    public Text Defence;
    public RawImage background;


    public void UpdateUi(int Damage,int Defence, string name )
    {
        TitleText.text = name;
        this.Damage.text = Damage.ToString();
        this.Defence.text = Defence.ToString();
    }


    public void loadImage(string url)
    {
        StartCoroutine(DownloadImage(url));
    }


    IEnumerator DownloadImage(string MediaUrl)
    {

        Debug.Log("call load image");
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
            Debug.Log(request.error);
        else
        {
            if (((DownloadHandlerTexture)request.downloadHandler).texture)
            {
                background.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            }
            else
            {
                Debug.LogError("we cant find our image");
            }
        }
            
        
    }




}
