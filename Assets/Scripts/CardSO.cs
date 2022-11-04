using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CardInstance", menuName = "CardModel")]

public class CardSO : ScriptableObject
{
    public string Title;
    public string url;
    public int Damage;
    public int Defence;


    public float getAverage()
    {
        return (Damage + Defence) / 2;
    }
}
