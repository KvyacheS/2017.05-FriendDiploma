using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCond : MonoBehaviour {

    public GameObject menu;
    public GameObject gamecontr;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Aliens"))
        {
            menu.SetActive(true);
            gamecontr.GetComponent<GameController>().endgame = true;
            GameObject.Find("GameController").GetComponent<GameController>().PauseUnpause();
            Alien.count = 0;
        }
    }
}
