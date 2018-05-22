using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject menu;
    public GameObject roboFrame;
    public GameObject ground;
    public GameObject dynamicObjects;
    public GameObject MonstroFrame;
    public GameObject Wall;
    public GameObject menu1;
    public GameObject aliens;
    public GameObject design;
    public bool endgame=false;
    public static int BegResources = 100;
    public static  int CurResources = 0;
    public GameObject txt;
    //public GameObject[] menus;
    bool paused = false;
	// Use this for initialization
    
	void Start () {
        //menu = GameObject.Find("InGameMenu");
        //menu.SetActive(false);
        Time.timeScale = 1;
        CurResources = BegResources;
        txt.GetComponent<GUIText>().text = GameController.CurResources.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && (endgame == false))
        {
            menu.SetActive(!menu.active);
            
            PauseUnpause();
        }
    }
    public void PauseUnpause()
    {
        if(!paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        ground.SetActive(paused);
        roboFrame.SetActive(paused);
        dynamicObjects.SetActive(paused);
        MonstroFrame.SetActive(paused);
        Wall.SetActive(paused);
        aliens.SetActive(paused);
        design.SetActive(paused);
        paused = !paused;
    }
    public void nextLevDial()
    {
        menu1.SetActive(true) ;
        PauseUnpause();
    }
}

