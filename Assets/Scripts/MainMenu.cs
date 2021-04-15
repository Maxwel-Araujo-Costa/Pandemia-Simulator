using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject carregamento = null;
    [SerializeField]
    private GameObject menu = null;
    [SerializeField]
    private GameObject opcoes = null;
    [SerializeField]
    private GameObject sobre = null;
    [SerializeField]
    private GameObject dificuldade = null;
    [SerializeField]
    private GameObject volume = null;
    public static Boolean dificil = false;
    [SerializeField]
    private GameObject marcaFacil = null;
    [SerializeField]
    private GameObject marcaDificil = null;
    [SerializeField]
    private GameObject videoIntro = null;
    [SerializeField]
    private GameObject musica = null;
    [SerializeField]
    private GameObject telaPreta = null;
    public static bool appIniciou=false;
    public void PlayGame()
    {
        Pontuacao.pontuacao=0;
        Player.questProgresso=0;
        Vidas.vidas=0;
        Player.karma=0;
        Player.questAtual=null;
        NPC.listaQuest=new List<Quest>(10);
        for (int i = 0; i < 10; ++i)
        {
            NPC.listaQuest.Add(null);
        }
        Invoke("LoadGameScene", 6f);
    }

    public void QuitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene("Quarto");
    }

    public void CarregarMenu()
    {
        menu.SetActive(false);
        carregamento.SetActive(true);
    }
    public void CarregarMenuVoltar()
    {
        carregamento.SetActive(false);
        menu.SetActive(true);
    }
    public void OpcoesMenu()
    {
        menu.SetActive(false);
        opcoes.SetActive(true);
    }
    public void OpcoesMenuVoltar()
    {
        opcoes.SetActive(false);
        menu.SetActive(true);
    }
    public void SobreMenu()
    {
        menu.SetActive(false);
        sobre.SetActive(true);
    }
    public void SobreMenuVoltar()
    {
        sobre.SetActive(false);
        menu.SetActive(true);
    }
    public void OpcoesMenuDificuldade()
    {
        opcoes.SetActive(false);
        dificuldade.SetActive(true);
    }
    public void OpcoesMenuDificuldadeVoltar()
    {
        dificuldade.SetActive(false);
        opcoes.SetActive(true);
    }
    public void OpcoesMenuVolume()
    {
        opcoes.SetActive(false);
        volume.SetActive(true);
    }
    public void OpcoesMenuVolumeVoltar()
    {
        volume.SetActive(false);
        opcoes.SetActive(true);
    }
    public void SetDificuldadeFacil()
    {
        dificil = false;
        marcaDificil.SetActive(false);
        marcaFacil.SetActive(true);
    }
    public void SetDificuldadeDificil()
    {
        dificil = true;
        marcaFacil.SetActive(false);
        marcaDificil.SetActive(true);
    }
    private void Start()
    {
        if(dificil==false)
        {
            marcaDificil.SetActive(false);
            marcaFacil.SetActive(true);
        }else{
            marcaFacil.SetActive(false);
            marcaDificil.SetActive(true);}

        StartCoroutine("Introducao");
    }

    IEnumerator Introducao()
    {
        if(appIniciou==false)
        {
            yield return new WaitForSeconds(16);
        }
        telaPreta.SetActive(false);
        videoIntro.SetActive(false);
        musica.SetActive(true);
        appIniciou=true;
        
    }


}
