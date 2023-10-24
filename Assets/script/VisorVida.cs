using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  TMPro;

public class VisorVida : MonoBehaviour
{
    private GerenciadorDoJOGO GJ;
    private TMP_Text texto;
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDoJOGO>();
        texto = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
       // texto.text= "Vida" + GJ.InformaVida().ToString().
    }
}
