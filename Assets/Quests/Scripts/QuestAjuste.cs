using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestAjuste : MonoBehaviour
{
    [SerializeField]
	public GameObject npc;
    [SerializeField]
	public GameObject npcFalso;
    [SerializeField]
	public int npcId;

    

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if((Player.questAtual==null)||(Player.questAtual.estaCompleta==true)||((Player.questAtual.estaCompleta==false)&&(Player.questAtual.id==npcId)))
        {
            npcFalso.SetActive(false);
            npc.SetActive(true);
        }
    }
}
