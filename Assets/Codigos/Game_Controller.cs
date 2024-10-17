using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    public GameObject hud;
    public GameObject armaMunicoes;
    public GameObject ArmaControle;
    public GameObject Jogador;

    public float tipoAtualMunicao = 0f;
    public float qntMunicao = 30f;
    public float tamPente = 30f;
    public float maxMunicao = 30f;
    public float pesoMunicao = 0.2f;

    public bool reloading = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Atirou()
    {
        qntMunicao--;
        hud.GetComponent<Textos>().setqntMunicao(qntMunicao);
    }


    public void Troca_De_Arma(string novaArma, string armaVelha)
    {
        Debug.Log(armaVelha + "  " + novaArma);
        if (armaVelha.Equals("Pistola1911(Clone)")) GetComponent<Pistola1911>().SetmunicaoAtual(qntMunicao);
        if (armaVelha.Equals("PistolaGlock(Clone)")) GetComponent<PistolaGlock>().SetmunicaoAtual(qntMunicao);
        if (armaVelha.Equals("Rifle(Clone)")) GetComponent<Rifle>().SetmunicaoAtual(qntMunicao);
        if (armaVelha.Equals("ShotGun(Clone)")) GetComponent<Shotgun>().SetmunicaoAtual(qntMunicao);

        if (novaArma.Equals("Pistola1911")) { qntMunicao = GetComponent<Pistola1911>().GetmunicaoAtual(); tamPente = GetComponent<Pistola1911>().GettamPente(); }
        if (novaArma.Equals("PistolaGlock")) { qntMunicao = GetComponent<PistolaGlock>().GetmunicaoAtual(); tamPente = GetComponent<PistolaGlock>().GettamPente(); }
        if (novaArma.Equals("Rifle")) { qntMunicao = GetComponent<Rifle>().GetmunicaoAtual(); tamPente = GetComponent<Rifle>().GettamPente(); }
        if (novaArma.Equals("ShotGun")) { qntMunicao = GetComponent<Shotgun>().GetmunicaoAtual(); tamPente = GetComponent<Shotgun>().GettamPente(); }

        hud.GetComponent<Textos>().setqntMunicao(qntMunicao);
        
    }

    public void Trocar_De_Municao(float tipo, float maxMunicao)
    {
        GetComponent<TipoMunicao>().Setmunicao((int)tipoAtualMunicao, this.maxMunicao);
        this.tipoAtualMunicao = tipo;
        this.maxMunicao = maxMunicao;
        qntMunicao = 0f;
        hud.GetComponent<Textos>().setqntMunicao(qntMunicao);
        hud.GetComponent<Textos>().setmaxMunicao(maxMunicao);
    }

    public void Recarregar()
    {
        reloading = true;
        Invoke("FimRecarregar", 3f);
    }

    public bool Municao_No_Pente()
    {
        if(qntMunicao > 0)
        {
            return true;
        }
        return false;
    }

    public bool Getreloading()
    {
        return reloading;
    }

    public float GetqntMunicao() 
    { 
        return qntMunicao;
    }

    public float gettamPente() 
    {
        return tamPente;
    }

    public float getmaxMunicao()
    {
        return maxMunicao;
    }

    
    public void FimRecarregar()
    {
        if (maxMunicao >= tamPente - qntMunicao)
        {
            maxMunicao -= tamPente - qntMunicao;
            qntMunicao = tamPente;
        }
        else
        {
            qntMunicao += maxMunicao;
            maxMunicao = 0;
        }    
        hud.GetComponent<Textos>().setqntMunicao(qntMunicao);
        hud.GetComponent<Textos>().setmaxMunicao(maxMunicao);
        reloading = false;
    }
}
