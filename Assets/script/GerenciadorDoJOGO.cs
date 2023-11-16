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
    public GameObject Telajogo;
    public TextMeshProUGUI TextVida;
    public TextMeshProUGUI TextPontos;
    public TextMeshProUGUI TextScoreGameOver;
    private Banco MeuBanco;
    public bool NovoGuarda = false;

    public void Inicio()
    {
        pontos = 0;
        vida = 3;
        int vida_compradas = PlayerPrefs.GetInt("nivelVida");
        vida = vida + vida_compradas;
        
    }

    private void Awake()
    {
        JogoOn = false;
        Time.timeScale = 0;
        MeuBanco = GetComponent<Banco>();
    }
    public void Play()
    {
        Inicio();
        JogoOn = true;
        Time.timeScale = 1f;
    }
    public int informeVida()
    {
        return vida;
    }
    void Update()
    {
        TextVida.text = vida.ToString();
        TextPontos.text = pontos.ToString();
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
            Telajogo.SetActive(false);
            TelaMorte.SetActive(true);
            //TelaJogo.SetActive(false);
            JogoOn = false;
            ReceberMoedasNaMorreu(pontos);
            Time.timeScale = 0;
        }
    }
    public void ReceberMoedasNaMorreu(int n_moedas)
    {
        MeuBanco.GuardarDinheiro(n_moedas);
        TextScoreGameOver.text = "Banco: "+MeuBanco.SaldoDinheiro().ToString()+"\n";
        TextScoreGameOver.text += "Pontos: "+pontos.ToString();
    }
    public int InformarValorNoBanco()
    {
        return MeuBanco.SaldoDinheiro();
    }
}
