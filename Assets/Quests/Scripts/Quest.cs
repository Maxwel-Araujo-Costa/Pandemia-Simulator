using System.Security.AccessControl;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public Boolean emProgresso=false;
    public Boolean estaCompleta=false;
    public string titulo="";
    public string descricao="";
    public int recompensaScore=0;
    public int recompensaKarma=0;
    public int id=999;

    public QuestObjetivo objetivo;

    public void Completa()
    {
        emProgresso=false;
        estaCompleta=true;
    }
}
