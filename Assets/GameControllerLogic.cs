using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Action UpdatePonitsInUi;

    private int _points;
    public int Points
    {
        get
        {
            return _points;
        }
        set
        {
            _points = value;
        }
    }

    void Start()
    {
        GameObject uiController = GameObject.Find("Canvas");
        UpdatePonitsInUi += uiController.GetComponent<UiManager>().UpdatePoints;
        GameObject player = GameObject.Find("cubePlayer");
        player.GetComponent<MovementPlayer>().CollisionAction = uiController.GetComponent<UiManager>().UpdatePoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
