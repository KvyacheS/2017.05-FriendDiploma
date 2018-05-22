using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour {

    public GameObject gc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResumeToGame()
    {
        
        GameObject.Find("InGameMenu").SetActive(false);
        GameObject.Find("GameController").GetComponent<GameController>().PauseUnpause();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void ExitToMenu()
    {

        SceneManager.LoadScene("MainMenu");
       // Application.LoadLevel(LevelName);
 
    }
    public void NextLevel(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }
}
