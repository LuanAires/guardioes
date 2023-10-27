using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GerenciadorDoJOGO : MonoBehaviour
{
    public bool JogoOn = false;
    public int pontos = 0;
    public int vida = 3;
    public GameObject TelaMorte;

    
     private void  Awake()
    {
        JogoOn = false;
        Time.timeScale = 0;
        
    }
    public void Play()
    {
        JogoOn=true;
        Time.timeScale = 1f;
    }
    
    void Update()
    {
        
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
            
        }
    }


}
