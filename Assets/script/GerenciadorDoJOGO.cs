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

     private void  Awake()
     {
        JogoOn = false;
        Time.timeScale = 0;      
     }
    public void iniciar()
    {
        int vida_compradas = Chao.GetInt("Ch")
    }
    public void Play()
    {
        JogoOn=true;
        Time.timeScale = 1f;
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
            Time.timeScale = 0;
        }
    }
}
