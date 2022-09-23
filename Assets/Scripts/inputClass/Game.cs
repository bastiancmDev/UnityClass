using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject enemyPf;
    public PoolEnemys poolEnemys;
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
        int indexOfRespawn = Random.Range(0, positionsRespawnEnemys.Length);
        GameObject enemyNew = poolEnemys.getEnemy();
        enemyNew.transform.position = positionsRespawnEnemys[indexOfRespawn].position + new Vector3(0, Random.Range(0, 10),0);
        enemyNew.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(RespawnEnemys());

    }


}
