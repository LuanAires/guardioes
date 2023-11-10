using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{

    public GerenciadorDoJOGO GJ;
    
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
        if (collision.tag == "lixo")
        {
            Destroy(collision.gameObject);
            GJ.PerderVida();           
        }
        if (collision.tag == "lixo")
        {           
            Rigidbody2D rigidbody2D = collision.GetComponent<Rigidbody2D>();
            rigidbody2D.velocity = Vector3.zero;
            rigidbody2D.isKinematic = true;
            rigidbody2D.mass = 1000;
            Collider2D collider = collision.GetComponent<Collider2D>();
            collider.isTrigger = false;
        }
        if (collision.tag == "comida")
        {
            Destroy(collision.gameObject);
          
        }
        if (collision.tag == "comida")
        {
           Rigidbody2D rigidbody2D = collision.GetComponent<Rigidbody2D>();
           rigidbody2D.velocity = Vector3.zero;
           rigidbody2D.isKinematic = true;
           rigidbody2D.mass = 1000;
           Collider2D collider = collision.GetComponent<Collider2D>();
           collider.isTrigger = false;
        }
    }

}


