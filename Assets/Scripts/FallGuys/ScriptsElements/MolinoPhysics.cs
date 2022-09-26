using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolinoPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float force;
    public bool invert;
    public float maxAngularVelocitySet;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = maxAngularVelocitySet;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (invert) {
            rb.AddTorque(Vector3.up * force * -1, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddTorque(Vector3.up * force , ForceMode.VelocityChange);
        }
       
    }


}
