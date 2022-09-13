using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 positionPlayer;
    public float sensibilidad;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionPlayer = transform.position;
        Mover();

        if (Input.GetKey(KeyCode.Backspace))
        {
            Destroy(gameObject);
        }

    }


    public void Mover()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // a = -1  d = 1
        float verticalInput = Input.GetAxis("Vertical");// w = -1  w = 1
        transform.Translate(new Vector3(horizontalInput, verticalInput,0) * sensibilidad);

    }
}
