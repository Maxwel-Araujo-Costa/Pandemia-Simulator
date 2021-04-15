using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAlter : MonoBehaviour
{
    [SerializeField]
    private float yMin = 0;
    [SerializeField]
    private float yMax = 0;
    [SerializeField]
    private float xMin = 0;
    [SerializeField]
    private float xMax = 0;
    [SerializeField]
    private int numItem = 0;
    [SerializeField]
    private float intervalo = 0.5f;

    public List<GameObject> spawnPool;

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
            SpawnItem();
            tempoIntervalo = intervalo;
        }
    }

    private void SpawnItem()
    {
        int itemAleatorio = 0;
        GameObject toSpawn;
        
        float bordaX, bordaY;
        Vector2 posi;

        for(int i=0; i < numItem; i++)
        {
            itemAleatorio = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[itemAleatorio];
            if(Player.karma < 0)
            {
                if(toSpawn.CompareTag("Enemy"))
                {
                    numItem += numItem*((Player.karma*-1)/500);
                }
                if(toSpawn.CompareTag("Respawn"))
                {
                    numItem -= numItem*((Player.karma*-1)/500);
                }
            }
            if(Player.karma > 0)
            {
                if(toSpawn.CompareTag("Enemy"))
                {
                    numItem -= numItem*(Player.karma/500);
                }
                if(toSpawn.CompareTag("Respawn"))
                {
                    numItem += numItem*(Player.karma/500);
                }
            }

            bordaX = Random.Range(xMin, xMax);
            bordaY = Random.Range(yMin, yMax);
            posi = new Vector2(bordaX, bordaY);

            Instantiate(toSpawn, posi, toSpawn.transform.rotation);
        }
    }
    private void destruirObjetos()
    {
        foreach (GameObject obj  in GameObject.FindGameObjectsWithTag("Respawn"))
        {
            Destroy(obj);
        }
    }
}
