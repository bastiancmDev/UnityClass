using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 positionPlayer;
    public Controls controlSystem;
    public Controls.MoveCubeActions moveCubeActions;
    public float sensibilidad;
    public Rigidbody rb;
    public Game _game;
    public float moveX, moveY;

    void Start()
    {
        controlSystem = new Controls();
        moveCubeActions = controlSystem.MoveCube;
        moveCubeActions.Enable();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = moveCubeActions.Move.ReadValue<float>();
        //print(moveX);
        moveY = moveCubeActions.MoveY.ReadValue<float>();
        //print(moveY);
        
    }


   

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void FixedUpdate()
    {
        Mover();
    }

    public void Mover()
    {
        Vector3 forceDirection = new Vector3(moveX, moveY, 0);
        forceDirection = forceDirection * sensibilidad - rb.velocity;
        rb.AddForce(forceDirection , ForceMode.VelocityChange);

    }
}
