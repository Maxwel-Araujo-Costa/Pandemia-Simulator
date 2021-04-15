using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetsSobre : MonoBehaviour
{
    [SerializeField]
    private GameObject autoresText = null;
    [SerializeField]
    private GameObject assetsLegendaText = null;
    [SerializeField]
    private GameObject assets1Text = null;
    [SerializeField]
    private GameObject assets2Text = null;
    [SerializeField]
    private GameObject assets3Text = null;
    [SerializeField]
    private GameObject assets4Text = null;
    [SerializeField]
    private GameObject assets5Text = null;
    [SerializeField]
    private GameObject assets6Text = null;
    [SerializeField]
    private GameObject assets7Text = null;
    [SerializeField]
    private GameObject assets8Text = null;
    [SerializeField]
    private GameObject assets9Text = null;
    [SerializeField]
    private GameObject assets10Text = null;
    [SerializeField]
    private GameObject assets11Text = null;
    [SerializeField]
    private GameObject assets12Text = null;
    [SerializeField]
    private GameObject assets13Text = null;
    [SerializeField]
    private GameObject assets14Text = null;
    [SerializeField]
    private GameObject assets15Text = null;
    [SerializeField]
    private GameObject assets16Text = null;
    [SerializeField]
    private GameObject assets17Text = null;
    [SerializeField]
    private GameObject assets18Text = null;
    [SerializeField]
    private GameObject assets19Text = null;
    [SerializeField]
    private GameObject assets20Text = null;
    [SerializeField]
    private GameObject assets21Text = null;
    [SerializeField]
    private GameObject assets22Text = null;
    [SerializeField]
    private GameObject btnAnterior = null;
    [SerializeField]
    private GameObject btnProximo = null;

    public void Proximo()
    {
        if(autoresText.activeSelf==true)
        {
            autoresText.SetActive(false);
            assetsLegendaText.SetActive(true);
            assets1Text.SetActive(true);
            btnAnterior.SetActive(true);
            return;
        }
        if(assets1Text.activeSelf==true)
        {
            assets1Text.SetActive(false);
            assets2Text.SetActive(true);
            return;
        }
        if(assets2Text.activeSelf==true)
        {
            assets2Text.SetActive(false);
            assets3Text.SetActive(true);
            return;
        }
        if(assets3Text.activeSelf==true)
        {
            assets3Text.SetActive(false);
            assets4Text.SetActive(true);
            return;
        }
        if(assets4Text.activeSelf==true)
        {
            assets4Text.SetActive(false);
            assets5Text.SetActive(true);
            return;
        }
        if(assets5Text.activeSelf==true)
        {
            assets5Text.SetActive(false);
            assets6Text.SetActive(true);
            return;
        }
        if(assets6Text.activeSelf==true)
        {
            assets6Text.SetActive(false);
            assets7Text.SetActive(true);
            return;
        }
        if(assets7Text.activeSelf==true)
        {
            assets7Text.SetActive(false);
            assets8Text.SetActive(true);
            return;
        }
        if(assets8Text.activeSelf==true)
        {
            assets8Text.SetActive(false);
            assets9Text.SetActive(true);
            return;
        }
        if(assets9Text.activeSelf==true)
        {
            assets9Text.SetActive(false);
            assets10Text.SetActive(true);
            return;
        }
        if(assets10Text.activeSelf==true)
        {
            assets10Text.SetActive(false);
            assets11Text.SetActive(true);
            return;
        }
        if(assets11Text.activeSelf==true)
        {
            assets11Text.SetActive(false);
            assets12Text.SetActive(true);
            return;
        }
        if(assets12Text.activeSelf==true)
        {
            assets12Text.SetActive(false);
            assets13Text.SetActive(true);
            return;
        }
        if(assets13Text.activeSelf==true)
        {
            assets13Text.SetActive(false);
            assets14Text.SetActive(true);
            return;
        }
        if(assets14Text.activeSelf==true)
        {
            assets14Text.SetActive(false);
            assets15Text.SetActive(true);
            return;
        }
        if(assets15Text.activeSelf==true)
        {
            assets15Text.SetActive(false);
            assets16Text.SetActive(true);
            return;
        }
        if(assets16Text.activeSelf==true)
        {
            assets16Text.SetActive(false);
            assets17Text.SetActive(true);
            return;
        }
        if(assets17Text.activeSelf==true)
        {
            assets17Text.SetActive(false);
            assets18Text.SetActive(true);
            return;
        }
        if(assets18Text.activeSelf==true)
        {
            assets18Text.SetActive(false);
            assets19Text.SetActive(true);
            return;
        }
        if(assets19Text.activeSelf==true)
        {
            assets19Text.SetActive(false);
            assets20Text.SetActive(true);
            return;
        }
        if(assets20Text.activeSelf==true)
        {
            assets20Text.SetActive(false);
            assets21Text.SetActive(true);
            return;
        }
        if(assets21Text.activeSelf==true)
        {
            assets21Text.SetActive(false);
            assets22Text.SetActive(true);
            btnProximo.SetActive(false);
            return;
        }
        
    }
    public void Anterior()
    {
        if(assets1Text.activeSelf==true)
        {
            assetsLegendaText.SetActive(false);
            assets1Text.SetActive(false);
            btnAnterior.SetActive(false);
            autoresText.SetActive(true);
            btnProximo.SetActive(true);
            return;
        }
        if(assets2Text.activeSelf==true)
        {
            assets2Text.SetActive(false);
            assets1Text.SetActive(true);
            return;
        }
        if(assets3Text.activeSelf==true)
        {
            assets3Text.SetActive(false);
            assets2Text.SetActive(true);
            return;
        }
        if(assets4Text.activeSelf==true)
        {
            assets4Text.SetActive(false);
            assets3Text.SetActive(true);
            return;
        }
        if(assets5Text.activeSelf==true)
        {
            assets5Text.SetActive(false);
            assets4Text.SetActive(true);
            return;
        }
        if(assets6Text.activeSelf==true)
        {
            assets6Text.SetActive(false);
            assets5Text.SetActive(true);
            return;
        }
        if(assets7Text.activeSelf==true)
        {
            assets7Text.SetActive(false);
            assets6Text.SetActive(true);
            return;
        }
        if(assets8Text.activeSelf==true)
        {
            assets8Text.SetActive(false);
            assets7Text.SetActive(true);
            return;
        }
        if(assets9Text.activeSelf==true)
        {
            assets9Text.SetActive(false);
            assets8Text.SetActive(true);
            return;
        }
        if(assets10Text.activeSelf==true)
        {
            assets10Text.SetActive(false);
            assets9Text.SetActive(true);
            return;
        }
        if(assets11Text.activeSelf==true)
        {
            assets11Text.SetActive(false);
            assets10Text.SetActive(true);
            return;
        }
        if(assets12Text.activeSelf==true)
        {
            assets12Text.SetActive(false);
            assets11Text.SetActive(true);
            return;
        }
        if(assets13Text.activeSelf==true)
        {
            assets13Text.SetActive(false);
            assets12Text.SetActive(true);
            return;
        }
        if(assets14Text.activeSelf==true)
        {
            assets14Text.SetActive(false);
            assets13Text.SetActive(true);
            return;
        }
        if(assets15Text.activeSelf==true)
        {
            assets15Text.SetActive(false);
            assets14Text.SetActive(true);
            return;
        }
        if(assets16Text.activeSelf==true)
        {
            assets16Text.SetActive(false);
            assets15Text.SetActive(true);
            return;
        }
        if(assets17Text.activeSelf==true)
        {
            assets17Text.SetActive(false);
            assets16Text.SetActive(true);
            return;
        }
        if(assets18Text.activeSelf==true)
        {
            assets18Text.SetActive(false);
            assets17Text.SetActive(true);
            return;
        }
        if(assets19Text.activeSelf==true)
        {
            assets19Text.SetActive(false);
            assets18Text.SetActive(true);
            return;
        }
        if(assets20Text.activeSelf==true)
        {
            assets20Text.SetActive(false);
            assets19Text.SetActive(true);
            return;
        }
        if(assets21Text.activeSelf==true)
        {
            assets21Text.SetActive(false);
            assets20Text.SetActive(true);
            return;
        }
        if(assets22Text.activeSelf==true)
        {
            assets22Text.SetActive(false);
            assets21Text.SetActive(true);
            return;
        }
    }
}
