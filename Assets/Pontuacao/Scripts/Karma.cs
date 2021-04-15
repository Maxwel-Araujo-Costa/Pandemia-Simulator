using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karma : MonoBehaviour
{
    [SerializeField]
    private Text karmaText = null;

    private void UpdateKarma() 
    {
        karmaText.text = Player.karma.ToString();
    }

    private void Update() 
    {
        UpdateKarma();
    }
}
