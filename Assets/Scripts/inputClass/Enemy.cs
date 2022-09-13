using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * -1);
        KillZ();
    }


    public void KillZ() {
        if (transform.position.z < -7.3f) {
            gameObject.SetActive(false);
            transform.parent.gameObject.GetComponent<PoolEnemys>().AddElemenToPool(gameObject);
        }
    }
}
