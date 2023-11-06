using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public bool botaoAtivado = false;
    public float tempo;
    public bool podeMover = false;
    public GerenciadorDoJOGO GJ;
    public AudioSource somCaranguejo;
    public AudioClip AudioAndando;

    void Start()
    {
        GJ = FindObjectOfType<GerenciadorDoJOGO>();
    }

    // Update is called once per frame
    void Update()
    {
        if (botaoAtivado == false)
            //MoverDedo();
        tempo += Time.deltaTime;
        if(tempo> 0.001f)
        {
            podeMover= true;
        }
        else
        {
            podeMover= false;
        }


    }
    void MoverDedo()
    {
        if (podeMover == true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 destino = Input.mousePosition;
                // corrigir posição
                Vector3 destinoCorrigido = Camera.main.ScreenToWorldPoint(destino);
                // Travar em X e Y
                Vector3 destinoFinal = new Vector3(destinoCorrigido.x, -4 + 0.5f, 0);
                //Jogador segue
                transform.position = Vector3.MoveTowards(transform.position, destinoFinal, 0.1f);

            }
        }

    }
    public void MoverE()
    {
        if (podeMover == true)
        {
            Vector3 destinoFinal = new Vector3(-2f, -4 + 0.5f, 0);
            //Jogador segue
            transform.position = Vector3.MoveTowards(transform.position, destinoFinal, 0.01f);
            somCaranguejo.PlayOneShot(AudioAndando);
        }
    }
    public void MoverD()
    {
        if (podeMover == true)
        {
            Vector3 destinoFinal = new Vector3(2f, -4 + 0.5f, 0);
            //Jogador segue
            transform.position = Vector3.MoveTowards(transform.position, destinoFinal, 0.01f);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="comida" || other.tag == "lixo") 
        {
            GJ.pontos++;
            Destroy(other.gameObject);
        }
    }

}


