using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucAnswer : MonoBehaviour
{
    [SerializeField] private bool correct;
    [SerializeField] private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameController.QaResponse(correct);
    }
}
