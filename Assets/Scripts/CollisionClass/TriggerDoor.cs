using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Door[] doorsToOpen;
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("<color=white>Error: </color>Entro a la Trigger");
        foreach (Door door in doorsToOpen) {
            door.Open();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("<color=white>Error: </color>salio a la Trigger");
        foreach (Door door in doorsToOpen)
        {
            door.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
