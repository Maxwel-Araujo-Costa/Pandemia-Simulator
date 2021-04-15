using System;
using System.Security;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenaCorrecao : MonoBehaviour {
 
    [SerializeField]
    public string andarEsquerdaAnterior="";
    [SerializeField]
    public string andarEsquerdaAtual="";
    [SerializeField]
    public float andarEsquerdaX=0;
    [SerializeField]
    public float andarEsquerdaY=0;


    public Transform player;
    private SpriteRenderer spriteRenderer;

    private GameObject jogador = null;
    public static Boolean virarPedido=false;

    
    public virtual void Start() {
        jogador = GameObject.FindGameObjectWithTag("Player");
        

        if (player == null)
        {
            player = jogador.transform;
        }
        if (Jogo.foiCarregado == true) 
        {
            Jogo.foiCarregado = false;
            player.position = new Vector2(Jogo.posX, Jogo.posY);
        }
        if ((CarregarFase.cenaAnterior==andarEsquerdaAnterior)&&(CarregarFase.cenaAtual==andarEsquerdaAtual)) 
        {
            player.position = new Vector2(andarEsquerdaX, andarEsquerdaY);
            if(Player.direita==false)
            {
                virarPedido=true;
            }
        }
    }
    
}
