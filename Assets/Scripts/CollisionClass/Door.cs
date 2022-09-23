using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 positionClose;
    public Vector3 positionOpen;
    public bool isOpen;
    public int speed;
    public bool avalibleToOpen;
    void Start()
    {
        isOpen = false;
        positionClose = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (avalibleToOpen) {
            if (isOpen)
            {
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, positionClose, speed * Time.deltaTime);
            }
            else
            {
                Debug.Log("<color=white>Error: </color>Entro a Abrir Puerta");
                 transform.localPosition = Vector3.MoveTowards(transform.localPosition, positionOpen, speed * Time.deltaTime);
            }
        }
    }

    public void Open() {
        Debug.Log("<color=white>Error: </color>Entro a Open");
        avalibleToOpen = true;
        isOpen = false;

    }

    public void Close()
    {
        Debug.Log("<color=white>Error: </color>Entro a Open");
        isOpen = true;

    }
}
