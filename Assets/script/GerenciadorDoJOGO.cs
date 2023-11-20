using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GerenciadorDoJOGO : MonoBehaviour
{
    [SerializeField] bool jogoOn = false;
    [SerializeField] bool novoGuarda = false;
    [SerializeField] int moedas = 0;
    [SerializeField] int vida = 3;
    private GameObject telaMorte;
    private GameObject telaJogo;
    private Banco meuBanco;
    UIManager uiManager;
    private void Awake()
    {
        uiManager = FindAnyObjectByType<UIManager>();
        meuBanco = GetComponent<Banco>();
        telaMorte = GameObject.Find("Tela Morte");
        telaJogo = GameObject.Find("Tela Jogo");
    }
    private void Start()
    {
        Time.timeScale = 0;
        jogoOn = false;
        telaJogo.SetActive(true);
        telaMorte.SetActive(false);
    }

    public void Play()
    {
        Inicio();
        jogoOn = true;
        Time.timeScale = 1f;
    }
    public void Inicio()
    {
        moedas = 0;
        vida = 3;
        int vida_compradas = PlayerPrefs.GetInt("nivelVida");
        vida = vida + vida_compradas;
    }

    void Update()
    {
        uiManager.textVida.text = vida.ToString();
        uiManager.textMoedas.text = moedas.ToString();
    }
    public bool EstadoJogo()
    {
        return jogoOn;
    }
    #region Gerenciamento De Vida
    public int informeVida()
    {
        return vida;
    }
    public void PerderVida()
    {
        vida--;
        ChecarMorte();
    }
    public void ChecarMorte()
    {
        if (vida >= 1) return;
        telaJogo.SetActive(false);
        telaMorte.SetActive(true);
        jogoOn = false;
        ReceberMoedasNaMorte(moedas);
        Time.timeScale = 0;
    }
    #endregion
    #region Administracao De Moeda
    public int InformarValorNoBanco()
    {
        return meuBanco.SaldoDinheiro();
    }
    public void GanharMoedas(int _moedas)
    {
        moedas += _moedas;
    }
    public void GanharMoedas()
    {
        moedas++;
    }
    public int GetMoedas()
    {
        return moedas;
    }
    public void ReceberMoedasNaMorte(int n_moedas)
    {
        meuBanco.GuardarDinheiro(n_moedas);
        uiManager.textScoreGameOver.text = "Banco: " + meuBanco.SaldoDinheiro().ToString() + "\n";
        uiManager.textScoreGameOver.text += "Pontos: " + moedas.ToString();
    }
    #endregion
}
