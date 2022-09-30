using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private Controls MoveCube;
    public Controls.MoveCubeActions playerInputOnMOveCube;
    private CameraLoockControl lookControl;
    void Start()
    {
        lookControl = gameObject.GetComponent<CameraLoockControl>();
        MoveCube = new Controls();
        playerInputOnMOveCube = MoveCube.MoveCube;
        MoveCube.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        lookControl.LoockProcess(playerInputOnMOveCube.CameraController.ReadValue<Vector2>());
    }
}
