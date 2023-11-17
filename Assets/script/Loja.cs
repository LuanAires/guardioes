using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
        private int BarraInfo;
        public TextMeshProUGUI MostrarValorCoracao;
        public TextMeshProUGUI MostrarValorGuardiao;
        //informacoes sobre meu coracao
        private int infocoracao= 1;
        private int infoGuardiao = 1 ;
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
            MostrarValorCoracao.text = "Vida Lv: " + infocoracao.ToString() + " $ : " + valorA.ToString();

            infocoracao = PlayerPrefs.GetInt("Guardiao");
            int valorB = infoGuardiao + 20;
            MostrarValorGuardiao.text = "Novo Guardiao Agumin: " + infoGuardiao.ToString() + " $ " + valorB.ToString();
            //Manter o valor da bolsa atualizado         
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
        infoGuardiao = PlayerPrefs.GetInt("Guardiao");
        int valorB = infoGuardiao * 5;       
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
