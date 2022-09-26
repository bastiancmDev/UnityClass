using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderJumpValidator : MonoBehaviour
{
    // Start is called before the first frame update
    public MovementPlayer playerMov;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (string.Equals(other.gameObject.tag, "Floor"))
        {
            playerMov.OnFloor = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (string.Equals(other.gameObject.tag, "Floor"))
        {
            playerMov.OnFloor = false;
        }
    }


    
}
