using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.GetFloat("lifesp");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.SetFloat("Xposition",player.transform.position.x);
            PlayerPrefs.SetFloat("Yposition", player.transform.position.y);
            PlayerPrefs.SetFloat("Zposition", player.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            player.transform.position = new Vector3(PlayerPrefs.GetFloat("Xposition"), PlayerPrefs.GetFloat("Yposition"), PlayerPrefs.GetFloat("Zposition"));
        }
    }
}
