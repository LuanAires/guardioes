using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GerenciadorDoJOGO : MonoBehaviour
{
    public bool JogoOn = false;
    public int pontos = 0;
    public int vida = 3;
    public GameObject TelaMorte;
    public TextMeshProUGUI TextVida;
    public TextMeshProUGUI TextPontos;
    private Banco MeuBanco;

    public void Inicio()
    {
        int vida_compradas = PlayerPrefs.GetInt("nivelVida");
        vida = vida + vida_compradas;
    }

    private void  Awake()
     {
        JogoOn = false;
        Time.timeScale = 0;
        MeuBanco = GetComponent<Banco>();
     }
     public void Play()
     {
        Inicio();   
        JogoOn=true;
        Time.timeScale = 1f;
     }
    public int informeVida()
    {
        return vida;
    } 
    void Update()
    {
        TextVida.text=vida.ToString();
        TextPontos.text=pontos.ToString();
    }
    public bool EstadoJogo()
    {
      return JogoOn;   
    }

    public void PerderVida()
    {
        vida--;
        if (vida < 1)
        {
            TelaMorte.SetActive(true);
            JogoOn = false;
            ReceberMoedasNaMorreu(pontos);
            Time.timeScale = 0;
        }
    }
    public void ReceberMoedasNaMorreu(int n_moedas)
    {
        MeuBanco.GuardarDinheiro(n_moedas);
    }
    public int InformarValorNoBanco()
    {
        return MeuBanco.SaldoDinheiro();
    }
}
