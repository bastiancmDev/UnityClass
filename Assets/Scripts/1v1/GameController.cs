using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public bool turno; //true = rojo //false = azul
    public GameObject firstPositionRed;
    public GameObject firstPositionBlue;

    public GameObject cubeRedPf;
    public GameObject cubeBluePf;
    public GameObject ObjectToDestroy;
    public string turnoView;
    public int indexRed;
    public int indexBlue;

    public int valueOfQ;






    void Start()
    {

        indexBlue = 0;
        indexRed = 0;
        turno = false;
        float randomTurno = Random.value;

        if(randomTurno > 0.5f)
        {
            turno = true;
        }
        print(turno);
        DefineValueOfQ();
        UpdateTurnoView();
    }


    public void UpdateTurnoView()
    {
        if (turno)
        {
            turnoView = "Red";
        }
        else
        {
            turnoView = "Blue";
        }
    }


    public void addElement(bool isRed)
    {
        if (isRed)
        {
            
            for(int i=0; i < valueOfQ ; i++)
            {
                indexRed++;
                Instantiate(cubeRedPf, firstPositionRed.transform.position + new Vector3(0, 0, 2 * indexRed), firstPositionRed.transform.rotation);
            }
            
        }
        else
        {
            
            for (int i = 0; i < valueOfQ; i++)
            {
                indexBlue++;
                Instantiate(cubeBluePf, firstPositionBlue.transform.position + new Vector3(0, 0, 2 * indexBlue), firstPositionBlue.transform.rotation);
            }
        }
    }

    // 0-10 paso de 0.2
    //float f = Random.Range(0,10)/50;

    public void DefineValueOfQ()
    {
        valueOfQ = Random.Range(1, 5);
    }

    public void QaResponse(bool responseAns)
    {
        if (responseAns)
        {
            if (!turno)
            {
                addElement(true);
            }
            else
            {
                addElement(false);
            }
        }
        else
        {
            if (!turno)
            {
                addElement(false);
            }
            else
            {
                addElement(true);
            }
        }
        ResetToNewQ();
    }

    public void ResetToNewQ()
    {
        turno = !turno;
        DefineValueOfQ();
        UpdateTurnoView();
    }

   
}
