using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class APERTARBOTAOE : Button
{
    // Start is called before the first frame update
    private GameObject personagem;
    void Start()
    {
        personagem = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPressed() == true)
        {
            personagem.GetComponent<Caranguejo>().MoverE();
        }
    }
}
