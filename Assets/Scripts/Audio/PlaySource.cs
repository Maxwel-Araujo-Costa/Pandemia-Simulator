using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySource : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;

    void Start()
    {
        volume = AudioMaster.volumeAtual;
        audioSource = GetComponent<AudioSource>();
        audioSource.volume=volume;
        audioSource.clip=clip;
        audioSource.Play();
        
    }
    public void AjustarVolume() 
    {
        audioSource.volume=AudioMaster.volumeAtual;
    }
}
