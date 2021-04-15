using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoDeVida : MonoBehaviour
{
    [SerializeField]
    private float tempoDeVida = 0f;

    private float timer = 0f;

    private void OnEnable() 
    {
        timer = tempoDeVida;
    }
    private void Update()
    {
        ContarTempoDeVida();
    }
    private void ContarTempoDeVida()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
