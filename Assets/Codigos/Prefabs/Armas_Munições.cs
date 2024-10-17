using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Armas_Munições : MonoBehaviour
{

    public Game_Controller controller;
    public GameObject armaControle;

    public GameObject rifle;
    public GameObject shotgun;
    public GameObject pistola1911;
    public GameObject pistolaGlock;
    public float tipoMunicao;

    private GameObject armaUsada = null;
    private UnityEngine.Vector3 posicaoArma = new UnityEngine.Vector3(0f,0f,0f);

    


    // Start is called before the first frame update
    void Start()
    {

        posicaoArma = new UnityEngine.Vector3(0.25f, -0.25f, 0.4f);
        armaUsada =  Instantiate(rifle, transform);
        armaUsada.transform.localPosition = posicaoArma;
        
    }

    // Update is called once per frame
    void Update()
    {
        //inicio da troca de armas
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(armaUsada != rifle)
            {
                Trocar_Arma(rifle);
            }
        }
        if(Input.GetKeyDown (KeyCode.Alpha2))
        {
            if (armaUsada != shotgun)
            {
                Trocar_Arma(shotgun);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (armaUsada != pistola1911)
            {
                Trocar_Arma(pistola1911);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (armaUsada != pistolaGlock)
            {
                Trocar_Arma(pistolaGlock);
            }
        }
        //fim da troca de armas
        if (Input.GetKeyDown(KeyCode.Q))
        {
            tipoMunicao--;
            if (tipoMunicao <0)
            {
                tipoMunicao = 3;
            }
            armaControle.GetComponent<Arma_controle>().MudarMassa(controller.GetComponent<TipoMunicao>().TrocaMunicao(tipoMunicao));
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            tipoMunicao++;
            if (tipoMunicao > 3)
            {
                tipoMunicao = 0;
            }
            armaControle.GetComponent<Arma_controle>().MudarMassa(controller.GetComponent<TipoMunicao>().TrocaMunicao(tipoMunicao));
        }
    }

    public void Trocar_Arma(GameObject armaNova)
    {
        controller.GetComponent<Game_Controller>().Troca_De_Arma(armaNova.name, armaUsada.name);
        Destroy(armaUsada);
        armaUsada = Instantiate(armaNova, transform);
        armaUsada.transform.localPosition = posicaoArma;

    }


}
