using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save
{
    public float jogadorPosicaoX = 0;
    public float jogadorPosicaoY = 0;
    public int pontuacao = 0;
    public int vidas = 0;
    public string cenaAtual = "Quarto";
    public Boolean dificuldade = false;
    public float volume = 1f;
    public int karma = 0;
    public List<Quest> todasQuests;
    public Quest questAtual;
    public int progresso = 0;
}
