using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] List<GameObject> listOfElements;
    [SerializeField] int indexOfIntemActive;
    [SerializeField] GameObject intemActive;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject item in listOfElements)
        {
            item.SetActive(false);
        }

        listOfElements[0].SetActive(true);
        indexOfIntemActive = 0;
        intemActive = listOfElements[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetItemActive(bool next)
    {
        Debug.Log("Se Cambio el item con indice" + next);
        listOfElements[indexOfIntemActive].SetActive(false);
        if (next)
        {
            indexOfIntemActive = (indexOfIntemActive + 1) % 4;
            listOfElements[indexOfIntemActive].SetActive(true);
        }
        else
        {
            indexOfIntemActive = (indexOfIntemActive - 1) % 4;
            listOfElements[indexOfIntemActive].SetActive(true);
        }

        intemActive = listOfElements[indexOfIntemActive];
    }


    public void RotateActiveElement(bool next)
    {
        Debug.Log("Se Rotara el indice" + next);
       
        if (next)
        {
            intemActive.transform.Rotate(0, 45, 0);
        }
        else
        {
            intemActive.transform.Rotate(0, -45, 0);
        }
    }



}
