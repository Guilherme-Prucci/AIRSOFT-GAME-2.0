using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    public Game_Controller controller;

    public string qntMunicao;
    public string maxMunicao;
    public string tipoMunicao;
    public string backSpinDrag;

    public TextMeshProUGUI hudMunicao;
    public TextMeshProUGUI hudBackSpinDrag;
    public TextMeshProUGUI hudTipoMunicao;
    // Start is called before the first frame update
    void Start()
    {
        maxMunicao = controller.GetComponent<Game_Controller>().gettamPente().ToString();
        qntMunicao = controller.GetComponent<Game_Controller>().GetqntMunicao().ToString();
        SetTipoMunicaoHud((int)controller.GetComponent<Game_Controller>().getTipoAtualMunicao());
        updateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setqntMunicao(float novoValor)
    {
        qntMunicao = novoValor.ToString();
        updateText();
    }

    public void setmaxMunicao(float NovoValor)
    {
        maxMunicao = NovoValor.ToString();
        updateText();
    }

    private void updateText ()
    {
        hudMunicao.text = qntMunicao + " / " + maxMunicao;
        hudBackSpinDrag.text = backSpinDrag;
        hudTipoMunicao.text = tipoMunicao;
    }    

    public void SetBackSpinDragHud(float NovoValor)
    {
        backSpinDrag = NovoValor.ToString();
        updateText();
    }

    public void SetTipoMunicaoHud(int NovoValor)
    {
        switch (NovoValor)
        {
            case 0:
                tipoMunicao = "0.20g";
                break;
            case 1:
                tipoMunicao = "0.24g";
                break;
            case 2:
                tipoMunicao = "0.32g";
                break;
            case 3:
                tipoMunicao = "0.40g";
                break;
        }
        updateText();
    }
}
