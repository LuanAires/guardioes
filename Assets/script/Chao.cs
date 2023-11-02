using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{

    public GerenciadorDoJOGO GJ;
    public int Vidas = 3;
    public int pontos = 0;
    //public GameObject AtivarLixo;
    void Start()
    {
        GJ = FindObjectOfType<GerenciadorDoJOGO>();
    }

    
    void Update()
    {
        
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "comida" || collision.tag == "lixo")
        {
            GJ.PerderVida();
        }
     
   
        if (collision.tag == "lixo")
        {

            //AtivarLixo.SetActive(true);
            Rigidbody2D rigidbody2D = collision.GetComponent<Rigidbody2D>();
            rigidbody2D.velocity = Vector3.zero;
            rigidbody2D.isKinematic = true;
            rigidbody2D.mass = 1000;

            Collider2D collider = collision.GetComponent<Collider2D>();
            collider.isTrigger = false;

        }
    }

}


