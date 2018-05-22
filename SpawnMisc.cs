using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMisc : MonoBehaviour
{

        public GameObject prefab;
        public int times = 1;
        public Vector3 offset;
        GameObject DynObj;
        // Use this for initialization
        void Start()
        {
        // Spawn first Sun in 10 seconds, repeat every 10 seconds
             DynObj = GameObject.Find("DynamicObjects");
             for (int i = 0; i < times; i++)
             {
                InvokeRepeating("Spawn", 5 + 0.5f * i, 5 );
             }
        }

        void Spawn()
        {

        if (DynObj != null)
        {
            Instantiate(prefab,
                    transform.position + offset,
                    Quaternion.identity, GameObject.Find("DynamicObjects").transform);
        }
        }

}

