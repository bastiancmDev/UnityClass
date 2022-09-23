using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVeloity : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Transform target;
    void Start()
    {
        Vector3 direction = Vector3.Normalize((target.position - transform.position));
        rb.AddForce(direction * 9000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
