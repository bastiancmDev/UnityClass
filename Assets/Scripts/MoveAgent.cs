using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;
public class MoveAgent : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent nvA;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePosition, out var hitInfo)){
                nvA.SetDestination(hitInfo.point);
            }
        }

    }
}
