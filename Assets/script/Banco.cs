using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    public int meuDinheiro = 0;
    void Start()
    {
        
    }

    public void GuardarDinheiro(int novoDinheiro)
    {
        meuDinheiro = novoDinheiro;
        PlayerPrefs.SetInt("Dinheiro", meuDinheiro);
    }
    public int SaldoDinheiro()
    {
        meuDinheiro = PlayerPrefs.GetInt("dinheiro");
        return meuDinheiro;
    }
    void Update()
    {
        
    }
}
