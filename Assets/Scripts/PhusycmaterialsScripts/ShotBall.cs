using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBall : MonoBehaviour
{
    // Start is called before the first frame update

    private Controls MoveCube;
    public Controls.MoveCubeActions playerInputOnMOveCube;
    public GameObject bulletToShot;
    public Camera cam;
    public GameObject positionToRespawn;
    public float forceToShoot;
    void Start()
    {
        MoveCube = new Controls();
        playerInputOnMOveCube = MoveCube.MoveCube;
        MoveCube.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerInputOnMOveCube.Shot.triggered)
        {
            GameObject currentBullet = Instantiate(bulletToShot, positionToRespawn.transform.position, cam.transform.rotation);
            currentBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * forceToShoot, ForceMode.VelocityChange);

        }
    }

}




