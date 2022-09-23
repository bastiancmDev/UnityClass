using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float force;
    private Rigidbody rb;
    public GameObject player;
    public bool launched;

    

    void Start()
    {
        player = GameObject.Find("player");
        rb = gameObject.GetComponent<Rigidbody>();
        launched = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        KillZ();
    }


    public void KillZ() {
        if (transform.position.z < -7.3f) {
            gameObject.SetActive(false);
            transform.parent.gameObject.GetComponent<PoolEnemys>().AddElemenToPool(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (launched) {
            Vector3 direccionForce = player.transform.position - transform.position;
            direccionForce = Vector3.Normalize(direccionForce);
            rb.AddForce(direccionForce * force, ForceMode.Impulse);
            launched = false;
        }
        
    }

    
}
