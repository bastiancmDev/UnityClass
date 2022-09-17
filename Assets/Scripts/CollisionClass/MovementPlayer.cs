using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
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
        //print(moveX);
        float moveY = moveCubeActions.MoveY.ReadValue<float>();
        //print(moveY);

        characterController.Move(new Vector3(moveX, 0, moveY) * Time.deltaTime * sensibilidad);

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("<color=white>Error: </color>Entro a la collision de CharacterController");
    }


}
