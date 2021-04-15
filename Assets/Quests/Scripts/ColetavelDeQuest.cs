using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetavelDeQuest : MonoBehaviour
{
    private AudioSource audioSource;
    public float volume=1f;
    public float idQuest=999;
    public AudioClip clip;
    [SerializeField]
    public GameObject itemQuest;
    private Boolean jaFoiPego=false;

    [SerializeField]
    public Player player;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update() 
    {
        if((player.quest.emProgresso==true)&&(jaFoiPego==false)&&(idQuest==player.quest.id))
        {
            itemQuest.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if((collision.CompareTag("Player"))&&(itemQuest.activeSelf)&&(idQuest==player.quest.id))
        {
            player.coletarItemDeQuest();
            volume=AudioMaster.volumeAtual;
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
            jaFoiPego=true;
            itemQuest.SetActive(false);
        }
    }
}
