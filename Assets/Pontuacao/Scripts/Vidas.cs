using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    [SerializeField]
    private Text vidasText = null;

    public static int vidas = 0;

    private void UpdateVidas() 
    {
        if (Pontuacao.pontuacao >= 10000)
        {
            Pontuacao.pontuacao -= 10000;
            vidas += 1;
        }
        if (Vidas.vidas < 0)
        {
            vidasText.text = 0.ToString();
            SceneManager.LoadScene("GameOver");
        }
        if (Vidas.vidas >= 0)
        {
            vidasText.text = vidas.ToString();
        }

    }

    private void Update() 
    {
        UpdateVidas();
    }
}
