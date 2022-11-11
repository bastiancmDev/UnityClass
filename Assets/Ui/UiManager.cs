using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    [SerializeField] private Text points;
    public Animator _animator;
    public bool showMenu;
    public GameObject WaponSelectorPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        showMenu = false;
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void showMenuPanel()
    {
        
        _animator.SetBool("ShowMenu", true);
        
    }


    public void UpdatePoints()
    {
        points.text = "100";
    }
}
