using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    public int ValorBanco;
    void Start()
    {
        
    }

    public void GuardarDinheiro(int novoDinheiro)
    {
        //Recebo o que já tem no banco
        ValorBanco = PlayerPrefs.GetInt("MinhasMoedas");
        // Soma o que já tem
        ValorBanco = ValorBanco + novoDinheiro;
        // Guarda o novo valor
        PlayerPrefs.SetInt("minhasMoedas", novoDinheiro);

    }
    public int SaldoDinheiro()
    {
        ValorBanco = PlayerPrefs.GetInt("dinheiro");
        return ValorBanco;
    }
    void Update()
    {
        
    }

}
