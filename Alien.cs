using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour {
    public static int count = 0;
    private int damage = 1;
    float nextatack = 0;
    GameObject txt;
    // Use this for initialization


    Animator Anim;

    public int Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    private void Start()
    {
        count++;
        txt = GameObject.Find("MonsterCounter");
        txt.GetComponent<GUIText>().text = count.ToString();
        Anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("gggg");
        if (collision.gameObject.CompareTag("Robots"))
        {
          
                if (Anim != null)
                {
                    Anim.SetBool("Attacking", true);
                }
           
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("gggg");
        if (collision.gameObject.CompareTag("Robots"))
        {
            nextatack -= Time.deltaTime;
            if (nextatack < 0)
            {
                collision.gameObject.GetComponent<Health>().doDamage(damage);
                nextatack = 1;
                if (Anim != null )
                {
                   // Anim.SetBool("Attacking", true);
                }
            }
        }
        
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
            if (Anim != null)
            {
                Anim.SetBool("Attacking", false);
            }   
    }

    private void OnDestroy()
    {
        GameObject gc;
        txt = GameObject.Find("MonsterCounter");
        if (txt != null)
        {
            txt = GameObject.Find("MonsterCounter");
            count--;
            txt.GetComponent<GUIText>().text = count.ToString();
            if ( count == 0)
            {
                gc = GameObject.Find("GameController");
                if (gc != null)
                {
                    gc.GetComponent<GameController>().endgame = true;
                    gc.GetComponent<GameController>().nextLevDial();
                }
                
            }
        }
    }
}
