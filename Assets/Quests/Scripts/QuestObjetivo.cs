using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestObjetivo
{
    public int quantidadePedida;
    public int quantidadeAtual;

    public bool foiCompletada()
    {
        return (quantidadeAtual >= quantidadePedida);
    }
    public void itemColetado()
    {
        quantidadeAtual++;
    }
}
