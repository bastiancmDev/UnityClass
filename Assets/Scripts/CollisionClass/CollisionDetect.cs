using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + "<color=red>Error: </color>Entro a la collision con " +  collision.gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("<color=blue>Error: </color>Salio de la collision");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("<color=white>Error: </color>Entro a la collision");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("<color=white>Error: </color>Entro a la Trigger");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("<color=white>Error: </color>Entro a la collision de CharacterController in collision detect");
    }
}
