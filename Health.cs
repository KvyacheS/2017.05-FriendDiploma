using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField]
    int cur = 5;

    public void doDamage(int n)
    {
        // Subtract damage from current health
        cur -= n;

        // Destroy if died
        if (cur <= 0)
            Destroy(gameObject);
    }
}
