using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPositionToWolrd : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 positionGlobal;
    void Start()
    {
        positionGlobal = transform.TransformPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        positionGlobal = transform.TransformPoint(transform.position);
    }
}
