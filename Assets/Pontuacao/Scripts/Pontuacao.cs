using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text pontuacaoText = null;

    public static int pontuacao = 0;

    private void UpdatePontuacao() 
    {
        pontuacaoText.text = pontuacao.ToString();
    }

    private void Update() 
    {
        UpdatePontuacao();
    }
}
