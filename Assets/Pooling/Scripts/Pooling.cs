using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pool = new GameObject[0];

    public GameObject spawn()
    {
        for(int i=0; i < pool.Length; i++)
        {
            if(!pool[i].activeInHierarchy)
            {
                return pool[i];
            }
        }
        return null;
    }
}
