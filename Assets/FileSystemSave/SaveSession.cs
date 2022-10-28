using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSession : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerStats playerStats = new PlayerStats("lUCIANO", 10, 3);
            SaveDataBinary.SaveData(playerStats);
            //Save();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerStats playerStats = SaveDataBinary.LoadData();

            //Debug.Log(playerStats.nameOfPlayer + " " + playerStats.coins + " " + playerStats.lifes);
        }
    }


    public void Save()
    {
        string jsonToSave = JsonUtility.ToJson(player.transform.position);
        print(Application.dataPath );
        File.WriteAllText( Application.dataPath + "/positionPlayer.json" , jsonToSave);
    }

    public void Load()
    {
        if(File.Exists(Application.dataPath + "/positionPlayer.json"))
        {
            string playerMovementOfJson = File.ReadAllText(Application.dataPath + "/positionPlayer.json");
            player.transform.position = JsonUtility.FromJson<Vector3>(playerMovementOfJson);
            print(playerMovementOfJson);
        }
    }



    
}
