using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject enemyPf;

    public Transform[] positionsRespawnEnemys;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RespawnEnemys());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator RespawnEnemys()
    {
        print("respwn Enemy");
        int indexOfRespawn = Random.Range(0, 7);
        Instantiate(enemyPf, positionsRespawnEnemys[indexOfRespawn].position + new Vector3(0, Random.Range(2, 10), 0), positionsRespawnEnemys[indexOfRespawn].rotation); ;
        yield return new WaitForSeconds(1);
        StartCoroutine(RespawnEnemys());

    }


}
