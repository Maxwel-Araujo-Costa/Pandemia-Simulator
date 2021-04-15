using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    private AudioSource audioSource;
    public float volume=1f;
    public AudioClip clip;
    [SerializeField]
    private float speed = 0f;
    [SerializeField]
    private string targetTag = "Player";
    [SerializeField]
    private int pontosNegativos = 0;

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
        if((!CarregarFase.carregar.activeSelf))
        {
            Float();
        }else{gameObject.SetActive(false);}
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag(targetTag))
        {
            volume=AudioMaster.volumeAtual;
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);

            if(MainMenu.dificil == true)
            {
                Pontuacao.pontuacao -= pontosNegativos*4;
            }else{Pontuacao.pontuacao -= pontosNegativos;}
            if(Pontuacao.pontuacao < 0)
            {
                Vidas.vidas -= 1;
                Pontuacao.pontuacao = 0;
            }
            gameObject.SetActive(false);
        }
    }
}
