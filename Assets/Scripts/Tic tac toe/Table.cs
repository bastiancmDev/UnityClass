using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public bool jugador;
    public bool jugando;

    public int[,] tablero;

    void Start()
    {
        jugando = true;
        jugador = true;
        tablero = new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i,j] = 0;
            }
        }
    }

    public void SetTablero(Cubo cubo, bool jugador)
    {
        if (jugador)
        {
            print("hola mundo");
            Debug.Log("hola mundo");
            tablero[cubo.i_Index, cubo.j_Index] = 2;
            cubo.SetColor(new Color(0.8396226f, 0.03564434f, 03564434f, 0));
        }
        else
        {
            tablero[cubo.i_Index, cubo.j_Index] = 1;
            cubo.SetColor(new Color(0.03529413f, 0.65382f, 8392157f, 0));
        }


    }


    public void OnClickCubo(Cubo cubo)
    {
        if(tablero[cubo.i_Index,cubo.j_Index] == 0 && jugando)
        {
            
            SetTablero(cubo, jugador);
            jugador = !jugador;
            

        }
        VerifyWinCondition();
    }

    public bool VerifyWinCondition()
    {

        

        return true;
    }


    





}
