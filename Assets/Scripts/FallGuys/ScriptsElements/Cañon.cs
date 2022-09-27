using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject bullet;
    public GameObject boquilla;
    public float delayToShoot;
    public float waitforBullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
        delayToShoot = Random.Range(2, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(delayToShoot);
        while (true)
        {
            GameObject bulletNew = Instantiate(bullet, boquilla.transform.position, boquilla.transform.rotation);
            bulletNew.GetComponent<Rigidbody>().AddForce(boquilla.transform.right * Random.Range(2500,5500), ForceMode.Impulse);
            yield return new WaitForSeconds(waitforBullet);
        }
        
        
    }
}
