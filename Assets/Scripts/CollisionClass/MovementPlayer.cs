using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 positionPlayer;
    public Controls controlSystem;
    public Controls.MoveCubeActions moveCubeActions;
    //public float sensibilidad;
    public float speed;
    public Rigidbody rb;
    public Vector3 velocityTg;
    public Vector3 velocityOfRb;
    //public CharacterController characterController;

    void Start()
    {
        
        controlSystem = new Controls();
        moveCubeActions = controlSystem.MoveCube;
        moveCubeActions.Enable();
        //characterController = gameObject.GetComponent<CharacterController>();
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
         velocityOfRb = rb.velocity;
    
    }


    public void Mover()
    {

        float moveX = moveCubeActions.Move.ReadValue<float>();
        //print(moveX);
        float moveY = moveCubeActions.MoveY.ReadValue<float>();
        //print(moveY);

        Vector3 targetVelocity = (new Vector3(moveX,0, moveY) * speed) ;
        velocityTg = targetVelocity;
        //targetVelocity = targetVelocity - rb.velocity;

        //targetVelocity.y = 0;


        rb.AddForce(targetVelocity, ForceMode.Impulse);

    }

    public void FixedUpdate()
    {
        Mover();
    }




}
