using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLoockControl : MonoBehaviour
{

    public Camera cam;
    private float xRotation = 0f;

    public float xSensi = 30f;
    public float ySensi = 30f;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
  //Locks the mouse in place
        //Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoockProcess(Vector2 input){
        float Xmouse = input.x;
        float mouseY = input.y;

        xRotation -= (mouseY * Time.deltaTime) * ySensi;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation,0,0);
        transform.Rotate(Vector3.up * (Xmouse * Time.deltaTime)* xSensi);

    }
}
