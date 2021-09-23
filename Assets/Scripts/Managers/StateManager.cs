using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doozy.Engine.UI;

public class StateManager : MonoBehaviour
{
    public static StateManager core;
    public bool gameStarted = false;
    public UIView mainMenu;

    void Awake()
    {
        if (core == null) { core = this; }
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!gameStarted) 
            { 
                gameStarted = true;
                HideMainMenu();
            }
        }
    }

    public void HideMainMenu()
    {
        mainMenu.transform.GetComponent<Image>().enabled = false;
        mainMenu.Hide();
    }
}
