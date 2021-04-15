using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaControl : MonoBehaviour
{
    [SerializeField]
    private GameObject painel = null;
    [SerializeField]
    private GameObject painelSave = null;
    [SerializeField]
    private GameObject painelCarregar = null;
    [SerializeField]
    private GameObject painelVolume = null;
    [SerializeField]
    private GameObject score = null;
    [SerializeField]
    private GameObject pauseButton = null;

    public void Pause()
    {
        score.SetActive(false);
        painel.SetActive(true);
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
    }
    public void Continuar()
    {
        painel.SetActive(false);
        score.SetActive(true);
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
    }

     public void Sair()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void TelaSalvar()
    {
        painel.SetActive(false);
        painelSave.SetActive(true);
        Time.timeScale = 0f;
    }
    public void TelaSalvarVoltar()
    {
        painelSave.SetActive(false);
        painel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void TelaCarregar()
    {
        painel.SetActive(false);
        painelCarregar.SetActive(true);
        Time.timeScale = 0f;
    }
    public void TelaCarregarVoltar()
    {
        painelCarregar.SetActive(false);
        painel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void TelaVolume()
    {
        painel.SetActive(false);
        painelVolume.SetActive(true);
        Time.timeScale = 0f;
    }
    public void TelaVolumeVoltar()
    {
        painelVolume.SetActive(false);
        painel.SetActive(true);
        Time.timeScale = 0f;
    }

}
