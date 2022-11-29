using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionLerp : MonoBehaviour
{
    public GameObject target;
    public Camera Maincamera;
    public float velocity;
    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(moveCameraPosition());
        StartCoroutine(RotateCameraPosition());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator moveCameraPosition()
    {
        float tramo = 0;
        while (Maincamera.transform.position != target.transform.position)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, target.transform.position, curve.Evaluate(tramo));
            tramo += 0.001f;
            yield return new WaitForSeconds(velocity);
        }
        yield return new WaitForSeconds(0);
    }


    IEnumerator RotateCameraPosition()
    {
        float tramo = 0;
        while (Maincamera.transform.rotation != target.transform.rotation)
        {
            Maincamera.transform.rotation = Quaternion.Lerp(Maincamera.transform.rotation, target.transform.rotation, curve.Evaluate(tramo));
            tramo += 0.001f;
            yield return new WaitForSeconds(velocity);
        }
        yield return new WaitForSeconds(0);
    }
}
