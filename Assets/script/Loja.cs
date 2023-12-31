using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCoracaoLoja;
    [SerializeField] TextMeshProUGUI txtMoedaLoja;

    //informacoes sobre meu coracao
    private int infocoracao= 1;
        private int infoGuardiao = 1 ;
        GerenciadorDoJOGO GJ;
        UIManager uiManager;
    // Start is called before the first frame update
    void Awake()
     {
        uiManager = FindAnyObjectByType<UIManager>();
        GJ = FindAnyObjectByType<GerenciadorDoJOGO>();
    }
    void Start()
    {
         
    }
    public void MostrarMoedasCoracao()
    {
        infocoracao = PlayerPrefs.GetInt("coracao");
        infoGuardiao = PlayerPrefs.GetInt("Guardiao");
        uiManager.textMoedas.text = infoGuardiao.ToString();
        uiManager.textVida.text = infocoracao.ToString();

    }
        // Update is called once per frame
    void Update()
    {               
        infocoracao = PlayerPrefs.GetInt("coracao");
        txtCoracaoLoja.text = infocoracao.ToString();
        int valorA = infocoracao * 20;
        uiManager.textValorCoracao.text = "Vida Lv: " + infocoracao.ToString() + " $ : " + valorA.ToString();

        infoGuardiao = PlayerPrefs.GetInt("Guardiao");
        txtMoedaLoja.text = GJ.InformarValorNoBanco().ToString();
        int valorB = infoGuardiao + 20;
        uiManager.textValorGuardiao.text = "Novo Guardiao Agumin: " + infoGuardiao.ToString() + " $ " + valorB.ToString();         
    }
    public void Comprar2(int tipo)
    {
        int valorA = infocoracao;
        int valorB = infoGuardiao;
    }
     //COMPRAR CORACAO
    
    public void BT_Vida()
    {
       infocoracao = PlayerPrefs.GetInt("coracao");
       int valorA = infocoracao * 5;
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
        int moedas = GJ.GetMoedas();
        //verificar se temos moedas
        if (valor <= moedas)
        {
            GJ.GanharMoedas(-valor);
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
