using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolaGlock : MonoBehaviour
{
    public Game_Controller controller;
    public float municaoAtual = 20;
    public float tamPente = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetmunicaoAtual(float municaoAtual)
    {
        Debug.Log(municaoAtual + "1 pg");
        this.municaoAtual = municaoAtual;
    }

    public float GetmunicaoAtual()
    {
        Debug.Log(municaoAtual + "2 pg");

        return this.municaoAtual;
    }

    public float GettamPente()
    {Debug.Log(tamPente + "3 pg");
        return this.tamPente;
    }
}
