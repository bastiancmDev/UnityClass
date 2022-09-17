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
    public CharacterController characterController;

    void Start()
    {
        controlSystem = new Controls();
        moveCubeActions = controlSystem.MoveCube;
        moveCubeActions.Enable();
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        Mover();
    }



   

    public void Mover()
    {
        
        float moveX = moveCubeActions.Move.ReadValue<float>();
        print(moveX);
        float moveY = moveCubeActions.MoveY.ReadValue<float>();
        print(moveY);

        characterController.Move(new Vector3(moveX, moveY, 0));

    }
}
