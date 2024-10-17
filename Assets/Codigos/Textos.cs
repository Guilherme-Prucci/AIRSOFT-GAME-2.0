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
    public TextMeshProUGUI hudMunicao;
    // Start is called before the first frame update
    void Start()
    {
        maxMunicao = controller.GetComponent<Game_Controller>().gettamPente().ToString();
        qntMunicao = controller.GetComponent<Game_Controller>().GetqntMunicao().ToString();
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
    }    
}
