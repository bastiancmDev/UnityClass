using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public int i_Index;
    public int j_Index;
    public Table padre;


    public void OnMouseDown()
    {
        padre.OnClickCubo(this);
    }

    void Start()
    {

        padre = GameObject.Find("tablero").GetComponent<Table>();
    }


    public void SetColor(Color color)
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
