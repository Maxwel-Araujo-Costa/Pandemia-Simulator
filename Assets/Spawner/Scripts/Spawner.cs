using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Pooling pool = null;
    [SerializeField]
    private float intervalo = 0.5f;

    private GameObject pooledObject = null;
    private Transform spawned = null;
    private float tempoIntervalo = 0f;

    private void Update()
    {
        CountIntervalo();
    }

    private void CountIntervalo()
    {
        if (tempoIntervalo > 0f)
        {
            tempoIntervalo -= Time.deltaTime;
        }
        else
        {
            Spawn();
            tempoIntervalo = intervalo;
        }
    }

    private void Spawn()
    {
        pooledObject = pool.spawn();
        if(pooledObject == null)
        {
            return;
        }

        spawned = pooledObject.transform;
        spawned.position = transform.position;
        spawned.rotation = transform.rotation;
        spawned.gameObject.SetActive(true);
    }
}
