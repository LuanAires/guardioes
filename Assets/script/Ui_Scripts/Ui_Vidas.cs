using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Vidas : MonoBehaviour
{

    private Chao Infochao;
    private Text MeuTexto;
    // Start is called before the first frame update
    void Start()
    {
        Infochao =GameObject.FindGameObjectWithTag("Lixeira").GetComponent<Chao>();
        MeuTexto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //MeuTexto.text= Infochao.InformeVida().ToString();
    }
}
