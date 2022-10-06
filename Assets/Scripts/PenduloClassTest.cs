using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenduloClassTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PenduloForce());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PenduloForce()
    {
        yield return new WaitForSeconds(1);
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.Normalize(rb.velocity) * 25, ForceMode.Force);
        StartCoroutine(PenduloForce());
    }
}
