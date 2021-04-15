using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOver = null;
    [SerializeField]
    private GameObject agradecimento = null;
    private void Update() 
    {
        if(Player.questProgresso > 4)
        {
            gameOver.SetActive(false);
            agradecimento.SetActive(true);
        }
        LooseGame();
    }
    public void LooseGame()
    {
        Vidas.vidas = 0;
        Pontuacao.pontuacao = 0;
        Invoke("LoadEnd", 5f);
    }
    private void LoadEnd()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
