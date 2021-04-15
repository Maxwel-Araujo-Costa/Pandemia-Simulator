using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMaster : MonoBehaviour
{

    private Slider volumeMestre;
    public static float volumeAtual=1f;
    void Awake() 
    {
        volumeMestre = GetComponent<Slider>();
        volumeMestre.value = volumeAtual;
    }

    void Update()
    {
        volumeAtual = volumeMestre.value;
        if(volumeMestre.value < 0.01){volumeAtual = 0;}
    }
}
