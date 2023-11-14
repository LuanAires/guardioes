using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{

        //Valor atual de moedas do jogador
        private int BarraInfo;
        //Valor a ser mostrado na tela
        public TextMeshProUGUI MostrarBolsa;
    ///MOSTRAR INFORMACAO CORACAO
        public TextMeshProUGUI MostrarValorCoracao;
        public TextMeshProUGUI MostrarValorGuardiao;
        //informacoes sobre meu coracao
        private int infocoracao;
        private int infoGuardiao;

        // Start is called before the first frame update
        void Start()
        {
         //Busca o Valor do Jogador
         BarraInfo = PlayerPrefs.GetInt("bolsa");
        }

        // Update is called once per frame
        void Update()
        {
            infocoracao = PlayerPrefs.GetInt("coracao");
            int valorA = infocoracao * 20;
            MostrarValorCoracao.text = "Vida Lv : " + infocoracao.ToString() + " $ : " + valorA.ToString();

            infocoracao = PlayerPrefs.GetInt("Guardiao");
            int valorB = infoGuardiao * 50;
            MostrarValorGuardiao.text = "Novo Guardiao Agumin : " + infoGuardiao.ToString() + " $ : " + valorB.ToString();
            //Manter o valor da bolsa atualizado
             BarraInfo = PlayerPrefs.GetInt("bolsa");
            //Atualizar no canvas
            MostrarValorGuardiao.text = BarraInfo.ToString();
        }
        public void Comprar2(int tipo)
        {

        }
        //COMPRAR CORACAO
        public void BT_Vida()
        {
            infocoracao = PlayerPrefs.GetInt("coracao");
            int valorA = infocoracao * 5;
            //informa valor do coracao e numero da compra 1
            Comprar(valorA, 1);
        }
    public void BT_Gurdiao()
    {
        infocoracao = PlayerPrefs.GetInt("Guardiao");
        int valorB = infocoracao * 5;
        //informa valor do coracao e numero da compra 1
        Comprar(valorB, 2);
    }
    //VERIFICO PAGAMENTO
    void Comprar(int valor, int numerodoproduto)
        {
            if (valor <= BarraInfo)
            {
                //Comprou
                //diminui valor
                BarraInfo = BarraInfo - valor;
                PlayerPrefs.SetInt("bolsa", BarraInfo);
                //CHamara finalização de compra
                FinalizarCompra(numerodoproduto);
            }

        }

        //ENTREGO PRODUTO
        void FinalizarCompra(int numero)
        {
            switch (numero)
            {
                case 1:
                    AumentarCoracoes();
                    break;
                default:
                    //NãoDeveOcorrer
                    break;
               case 2:
                AumentarGuardioes();
                break;                                    
            }
        }
        void AumentarCoracoes()
        {
            int coracao = PlayerPrefs.GetInt("coracao");
            coracao++;
            PlayerPrefs.SetInt("coracao", coracao);
        }
    void AumentarGuardioes()
    {
        int Guardiao = PlayerPrefs.GetInt("Guardiao");
        Guardiao++;
        PlayerPrefs.SetInt("coracao", Guardiao);
    }

}
