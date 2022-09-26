using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueAdd : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Vector3 angulaVelocity;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        angulaVelocity = new Vector3();
        rb.maxAngularVelocity = 40;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 1, 0);
    }

    private void FixedUpdate()
    {
        
        rb.AddTorque(Vector3.up * 1000000, ForceMode.Force);
        angulaVelocity = rb.angularVelocity;
    }
}
