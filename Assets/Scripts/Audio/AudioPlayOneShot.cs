using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayOneShot : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;

    void Start()
    {
        volume = AudioMaster.volumeAtual;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(clip, volume);
    }
}
