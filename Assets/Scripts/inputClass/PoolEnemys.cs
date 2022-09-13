using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolEnemys : MonoBehaviour
{
    public List<GameObject> pool;
    public GameObject enemyPf;
    public int numbOfSeeds;
    // Start is called before the first frame update
    void Start()
    {
        pool = new List<GameObject>();

        for(int i =0; i<numbOfSeeds; i++)
        {
            GameObject currentEnemy = Instantiate(enemyPf,transform);

            currentEnemy.SetActive(false);

            pool.Add(currentEnemy);

        }

    }

    public GameObject getEnemy()
    {
        GameObject current;
        if ( pool.Count > 0)
        {
            current = pool[0];
            pool.RemoveAt(0);
        }
        else
        {
             current = Instantiate(enemyPf, transform);
        }

       
        return current;
    }

    public void AddElemenToPool(GameObject enemyToPool) {
        pool.Add(enemyToPool);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
