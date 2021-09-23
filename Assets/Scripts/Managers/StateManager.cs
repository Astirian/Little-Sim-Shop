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
    public float menuMusicVolume = 0.25f;

    void Awake()
    {
        if (core == null) { core = this; }
    }

    void Start()
    {
       MusicManager.core.PlayMusic(MusicManager.core.trackList[0], menuMusicVolume);
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
