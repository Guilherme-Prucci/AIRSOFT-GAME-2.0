using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    public Game_Controller controller;
    public float municaoAtual = 30f;
    public float tamPente = 30f;
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
        this.municaoAtual = municaoAtual;
        Debug.Log(municaoAtual + "1 r");
    }

    public float GetmunicaoAtual()
    {Debug.Log(municaoAtual + "2 r");
        return this.municaoAtual;
    }

    public float GettamPente()
    {Debug.Log (tamPente + "3 r");
        return this.tamPente;
    }
}
