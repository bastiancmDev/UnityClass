using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GreenPathToObject : MonoBehaviour
{

    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {

        agent = gameObject.GetComponent<NavMeshAgent>();
        
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray movePostion = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePostion, out var hitInfo))
            {
                
                agent.SetDestination(hitInfo.point);
            }
        }
    }
    // Update is called once per frame

}
