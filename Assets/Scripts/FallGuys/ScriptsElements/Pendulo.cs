using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulo : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float maxAngularVelocitySet;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = maxAngularVelocitySet;
        StartCoroutine(Move());
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Move()
    {
        while (true)
        {
            rb.AddTorque(Vector3.forward * 100, ForceMode.Acceleration);
            yield return new WaitForSeconds(1.2f);
            rb.AddTorque(Vector3.forward * 100 * -1, ForceMode.Acceleration);
            yield return new WaitForSeconds(0.1f);
            rb.AddTorque(Vector3.forward * 100 * -1, ForceMode.Acceleration);
            yield return new WaitForSeconds(1.2f);
            rb.AddTorque(Vector3.forward * 100, ForceMode.Acceleration);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
