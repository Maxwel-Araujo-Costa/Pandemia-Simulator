using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;


public class CarregarFase : MonoBehaviour
{
    private AudioSource audioSource;
    public float volume=1f;
    public AudioClip clip;
    [SerializeField]
    public string novaCena="";
    [SerializeField]
    private GameObject carregamento = null;
    public static GameObject carregar = null;
    [SerializeField]
    private GameObject score = null;
    private Boolean teleportar=false;
    public static string cenaAnterior="";
    public static string cenaAtual="";

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        volume=AudioMaster.volumeAtual;
        carregar=carregamento;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
         teleportar = true;
    }
    void OnTriggerExit2D (Collider2D other)
    {
         teleportar = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(teleportar==true)
            {
                cenaAnterior=SceneManager.GetActiveScene().name;
                cenaAtual=novaCena;

                audioSource.PlayOneShot(clip, volume);
                score.SetActive(false);
                if(Player.questProgresso > 4)
		        {
			        SceneManager.LoadScene("GameOver");
		        }
                carregamento.SetActive(true);
                StartCoroutine("LoadAsyncScene");

            }

        }
    }
    IEnumerator LoadAsyncScene()
    {
        yield return new WaitForSeconds(7);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(novaCena);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
