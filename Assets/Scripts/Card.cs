using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    public string Title ;
    public int Damage;
    public int Defence;
    public CardSO cardReference;
    public UpdateUiHandler updateUiHandler;

    void Start()
    {
        updateUiHandler = gameObject.GetComponent<UpdateUiHandler>();
        init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void init()
    {
        Title = cardReference.Title;
        Damage = cardReference.Damage;
        Defence = cardReference.Defence;
        updateUiHandler.UpdateUi(Damage,Defence,name);
        updateUiHandler.loadImage(cardReference.url);

    }



}
