using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Quest quest;
    public static List<Quest> listaQuest = new List<Quest>(10);
    private int numeroQuest = 0;
    public Player player;
    public GameObject dialogoQuest;
    public GameObject conversa;
    public GameObject agradecimento;
    public Text titulo;
    public Text descricao;
    public Text pontuacao;
    public Text karma;
    public GameObject geradores;
    

    public void abrirConversa()
    {
        conversa.SetActive(true);
    }
    public void abrirQuest()
    {
        conversa.SetActive(false);
        dialogoQuest.SetActive(true);
        geradores.SetActive(false);
        titulo.text = quest.titulo;
        descricao.text = quest.descricao;
        pontuacao.text = quest.recompensaScore.ToString();
        karma.text = quest.recompensaKarma.ToString();
    }
    public void aceitarQuest()
    {
        
        quest.emProgresso = true;
        listaQuest[numeroQuest] = quest;
        player.quest = quest;
        Player.questAtual = quest;
        dialogoQuest.SetActive(false);
        geradores.SetActive(true);
    }
    public void rejeitarQuest()
    {
        dialogoQuest.SetActive(false);
        geradores.SetActive(true);
        Player.karma -= quest.recompensaKarma;
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))
        {
            if((quest.estaCompleta==false)&&(dialogoQuest.activeSelf==false)&&(quest.emProgresso == false))
            {
                if((Player.questAtual != null)&&(Player.questAtual.emProgresso == false))
                {
                    abrirConversa();
                }
                if(Player.questAtual == null)
                {
                    abrirConversa();
                }
            }
            if((quest.objetivo.foiCompletada())&&(quest.estaCompleta==false))
			{
                agradecimento.SetActive(true);
				Pontuacao.pontuacao += quest.recompensaScore;
				Player.karma += quest.recompensaKarma;
				quest.Completa();
                listaQuest[numeroQuest] = quest;
                Player.questProgresso++;
                Time.timeScale = 0f;
                if(quest.id==1)
                {
                    Vidas.vidas += 5;
                }
			}
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(agradecimento.activeSelf){agradecimento.SetActive(false);}
    }
    private void Start() 
    {
        /*if(!listaQuest.Exists(e => e.id==quest.id))
            {
                listaQuest.Insert(numeroQuest, new Quest() 
                { 
                    id=quest.id,
                    emProgresso=quest.emProgresso, estaCompleta = quest.estaCompleta,
                    titulo=quest.titulo, descricao=quest.descricao,
                    recompensaScore=quest.recompensaScore, recompensaKarma=quest.recompensaKarma
                });
            }else{quest=listaQuest[numeroQuest];}*/
        
        if(listaQuest[quest.id-1]==null)
            {
                listaQuest[quest.id-1]= new Quest() 
                { 
                    id=quest.id,
                    emProgresso=quest.emProgresso, estaCompleta = quest.estaCompleta,
                    titulo=quest.titulo, descricao=quest.descricao,
                    recompensaScore=quest.recompensaScore, recompensaKarma=quest.recompensaKarma
                };
            }else{quest=listaQuest[quest.id-1];}
        if((Player.questAtual != null)&&(Player.questAtual.titulo==quest.titulo))
        {
            quest = Player.questAtual;
        }
    }
    public void TerminarConversa()
    {
        agradecimento.SetActive(false);
        Time.timeScale = 1f;
    }
}
