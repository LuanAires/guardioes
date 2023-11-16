using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{

    const string tagmoedas = "MinhasMoedas";

    public int ValorBanco;
    void Start()
    {
        
    }

    public void GuardarDinheiro(int novoDinheiro)
    {
        //Recebo o que j� tem no banco
        ValorBanco = PlayerPrefs.GetInt(tagmoedas);
        // Soma o que j� tem
        ValorBanco = ValorBanco + novoDinheiro;
        // Guarda o novo valor
        PlayerPrefs.SetInt(tagmoedas, novoDinheiro);

    }
    public int SaldoDinheiro()
    {
        ValorBanco = PlayerPrefs.GetInt(tagmoedas);
        return ValorBanco;
    }
    void Update()
    {
        
    }

}
