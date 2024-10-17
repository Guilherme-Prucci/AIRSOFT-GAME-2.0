using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class TipoMunicao : MonoBehaviour
{

    public float Municao20 = 200f;
    public float Municao24 = 100f;
    public float Municao32 = 50f;
    public float Municao40 = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float TrocaMunicao(float tipo)
    {
        switch (tipo)
        {
            case 0:
                GetComponent<Game_Controller>().Trocar_De_Municao(0,Municao20);
                return 0.2f;
            case 1:
                GetComponent<Game_Controller>().Trocar_De_Municao(1,Municao24);
                return 0.24f;
            case 2:
                GetComponent<Game_Controller>().Trocar_De_Municao(2,Municao32);
                return 0.32f;
            case 3:
                GetComponent<Game_Controller>().Trocar_De_Municao(3,Municao40);
                return 0.4f;
        }
        return 0.2f;
    }

    public void ColetouMunicao(int tipo, float qnt)
    {
        switch (tipo)
        {
            case 0:
                Municao20 += qnt;
                break;
            case 1:
                Municao24 += qnt;
                break;
            case 2:
                Municao32 += qnt;
                break;
            case 3:
                Municao40 += qnt;
                break;
        }
    }

    public void Setmunicao(int tipo, float municao)
    {
        switch (tipo)
        {
            case 0:
                Municao20 = municao;
                break;
            case 1:
                Municao24 = municao;
                break;
            case 2:
                Municao32 = municao;
                break;
            case 3:
                Municao40 = municao;
                break;
        }
    }
}
