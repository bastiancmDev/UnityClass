using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 positionPlayer;
    public Controls controlSystem;
    public Controls.MoveCubeActions moveCubeActions;
    public AudioSource audioSource;
    //public float sensibilidad;
    public float speed;
    public float speedJump;
    public Rigidbody rb;
    public Vector3 velocityTg;
    public Vector3 velocityOfRb;
    public float moveX;
    public float moveY;
    public bool jumpEnable;
    public bool OnFloor;
    public Delegate CollisionDelegate;
    public Action CollisionAction;
    public bool vidrio;
    public AudioClip vidrioSound;
    public AudioClip maderaSound;

    //public CharacterController characterController;

    void Start()
    {
        
        controlSystem = new Controls();
        moveCubeActions = controlSystem.MoveCube;
        moveCubeActions.Enable();
        //characterController = gameObject.GetComponent<CharacterController>();
        rb = gameObject.GetComponent<Rigidbody>();
        jumpEnable = false;

        if (vidrio)
        {
            audioSource.clip = vidrioSound;

        }
        else
        {
            audioSource.clip = maderaSound;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        if (moveCubeActions.Jump.triggered)
        {
            jumpEnable = true;
        }
        
        moveX = moveCubeActions.Move.ReadValue<float>();
        //print(moveX);
        moveY = moveCubeActions.MoveY.ReadValue<float>();
        //print(moveY);

    }


    public void printMessage()
    {
        print(" ha colisionado con un objeto");
    }


    public void Mover()
    {

        

        Vector3 targetVelocity = (new Vector3(moveX,0, moveY) * speed) ;
        velocityTg = targetVelocity;
        //targetVelocity = targetVelocity - rb.velocity;

        //targetVelocity.y = 0;

        
        rb.AddForce(targetVelocity, ForceMode.Impulse);

    }

    public void FixedUpdate()
    {
        Mover();
        JumpCh();


       

        RaycastHit hit;

        if (Physics.Raycast(transform.position,transform.forward, out hit, 9000, LayerMask.GetMask("UI"))){

            Debug.DrawLine(transform.position, hit.point, Color.red);
        }

        
        
    }


    public void JumpCh() {
        if(jumpEnable && OnFloor){ 
            rb.AddForce(Vector3.up * speedJump, ForceMode.VelocityChange);
            jumpEnable = false;
        }
        else
        {
            //rb.AddForce(Vector3.up * 5 * -1, ForceMode.VelocityChange);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
        
    }








}
