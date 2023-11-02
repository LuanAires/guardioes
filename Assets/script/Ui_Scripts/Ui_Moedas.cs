using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Moedas : MonoBehaviour
{
    
    private Text MeuTexto;
    private Chao InfJogador;
    // Start is called before the first frame update
    void Start()
    {
        InfJogador = GameObject.FindGameObjectWithTag("Lixeira").GetComponent<Chao>();
        MeuTexto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //MeuTexto.text = InfJogador.pontos.ToString();
    }
}

