using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjeto : MonoBehaviour
{
    public List <GameObject> Bolas;

    public float tempo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        if (tempo > 2f )
        {
            tempo = 0;
            float posX = Random.Range(-2, 2);
            Vector3 nova = new Vector3(posX, 6, 0);
            int indice =Random.Range(0, 4);
            GameObject novaBolinha = Instantiate( Bolas[indice],nova, Quaternion.identity);
            Destroy(novaBolinha, 2f);
        }
        
    }
}
