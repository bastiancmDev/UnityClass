using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantObject : MonoBehaviour
{
    // Start is called before the first frame update
    public int objectToCreate;
    public int objectsCreated;
    public GameObject game;
    public float timeToDelay;
    void Start()
    {
        objectsCreated = 0;
        StartCoroutine(CreateObjects());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator CreateObjects()
    {
        while (objectsCreated < objectToCreate)
        {
            Instantiate(game, new Vector3(Random.RandomRange(0, 90), 0, Random.RandomRange(0, 90)), transform.rotation);
            objectsCreated++;
            yield return new WaitForSeconds(timeToDelay);
        }
    }

    



}
