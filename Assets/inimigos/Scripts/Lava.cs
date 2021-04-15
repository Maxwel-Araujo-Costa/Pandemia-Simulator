using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    private AudioSource audioSource;
    public float volume=1f;
    public AudioClip clip;
    [SerializeField]
    private string targetTag = "Player";
    [SerializeField]
    private int pontosNegativos = 0;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag(targetTag))
        {
            volume=AudioMaster.volumeAtual;
            audioSource.PlayOneShot(clip, volume);

            if(MainMenu.dificil == true)
            {
                Pontuacao.pontuacao -= pontosNegativos*4;
            }else{Pontuacao.pontuacao -= pontosNegativos;}
            if(Pontuacao.pontuacao < 0)
            {
                Vidas.vidas -= 1;
                Pontuacao.pontuacao = 0;
            }
            
        }
    }
}
