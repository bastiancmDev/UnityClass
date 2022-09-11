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

        if (Input.GetKey("a"))
        {
            Destroy(gameObject);
        }

    }


    public void Mover()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput,0) * sensibilidad);

    }
}
