using System.Security.Cryptography;
using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Jogo : MonoBehaviour
{
    [SerializeField]
    private GameObject jogador = null;
    private int botaoN=-10;
    public static float posX=0;
    public static float posY=0;
    public static Boolean foiCarregado = false;

    private Save CriarSalvamento()
    {
        Save save = new Save();

        if (jogador == null)
        {
            jogador = GameObject.FindGameObjectWithTag("Player");
        }
            
        save.jogadorPosicaoX = jogador.transform.position.x;
        save.jogadorPosicaoY = jogador.transform.position.y;


        Scene scene = SceneManager.GetActiveScene();
        save.cenaAtual = scene.name;
        save.pontuacao = Pontuacao.pontuacao;
        save.vidas = Vidas.vidas;
        save.dificuldade = MainMenu.dificil;
        save.volume = AudioMaster.volumeAtual;
        save.karma = Player.karma;
        save.todasQuests = new List<Quest>(NPC.listaQuest);
        save.questAtual = Player.questAtual;
        save.progresso=Player.questProgresso;
        return save;
    }

    public void Botao1()
    {
        botaoN = 1;
    }
    public void Botao2()
    {
        botaoN = 2;
    }
    public void Botao3()
    {
        botaoN = 3;
    }
    public void Botao4()
    {
        botaoN = 4;
    }
    public void Botao5()
    {
        botaoN = 5;
    }

    public void SavarJogo()
    {
        Save save = CriarSalvamento();
        string nomeS = "/pandemia"+botaoN.ToString();
        BinaryFormatter bf = new BinaryFormatter();

        FileStream file = File.Create(Application.persistentDataPath + nomeS+".save");
        bf.Serialize(file, save);
        file.Close();
    }

    public void CarregarJogo()
    {
        string nomeS = "/pandemia"+botaoN.ToString();
        if (File.Exists(Application.persistentDataPath + nomeS+".save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + nomeS+".save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            if (jogador == null)
            {
                jogador = GameObject.FindGameObjectWithTag("Player");
            }

            SceneManager.LoadScene(save.cenaAtual);
            foiCarregado = true;

            posX=save.jogadorPosicaoX;
            posY=save.jogadorPosicaoY;
            
            Pontuacao.pontuacao = save.pontuacao;
            Vidas.vidas = save.vidas;
            MainMenu.dificil = save.dificuldade;
            AudioMaster.volumeAtual = save.volume;
            Player.karma = save.karma;
            NPC.listaQuest = new List<Quest>(save.todasQuests);
            Player.questAtual = save.questAtual;
            Player.questProgresso=save.progresso;
            
            Time.timeScale = 1f;

        }
        else
        {
            Debug.Log("Não existe jogo salvo");
        }
    }



}
