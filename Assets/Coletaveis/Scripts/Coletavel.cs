using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    private AudioSource audioSource;
    public float volume=1f;
    public AudioClip clip;
    [SerializeField]
    private float speed = 0f;
    [SerializeField]
    private string targetTag = "Player";
    [SerializeField]
    private int pontos = 0;

    private Vector3 posicaoDesejada = Vector3.zero;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Float()
    {
        posicaoDesejada = transform.position;
        posicaoDesejada.x -= speed;
        transform.position = Vector3.Lerp(transform.position, posicaoDesejada, speed * Time.deltaTime);
    }

    private void Update() 
    {
        Float();
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag(targetTag))
        {
            volume=AudioMaster.volumeAtual;
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
            if ((pontos < 10000) && (MainMenu.dificil == true)) 
            {
                Pontuacao.pontuacao += pontos/4;
            }else{Pontuacao.pontuacao += pontos;}
            gameObject.SetActive(false);
        }
    }
}
