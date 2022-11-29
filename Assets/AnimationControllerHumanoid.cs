using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;

public class AnimationControllerHumanoid : MonoBehaviour
{
    // Start is called before the first frame update
    const string AnimationTree = "VelocityRun";
    public Animator animatorController;
    public BlendTree blendTree;
    public NavMeshAgent agent;
    void Start()
    {
        animatorController = gameObject.GetComponent<Animator>();
        animatorController.SetFloat(AnimationTree, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("VELOCIDAD DEL AGENTE  " + (Vector3.Magnitude(agent.velocity)/ agent.speed ));
        animatorController.SetFloat(AnimationTree, (Vector3.Magnitude(agent.velocity) / agent.speed));
        //Debug.Log("VELOCIDAD DEL AGENTE  desired" + agent.desiredVelocity);
    }
}
