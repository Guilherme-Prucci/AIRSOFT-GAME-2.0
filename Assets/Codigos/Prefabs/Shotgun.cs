using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public Game_Controller controller;
    public float municaoAtual = 8f;
    public float tamPente = 8f;
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
        Debug.Log(municaoAtual + "1 12");
    }

    public float GetmunicaoAtual()
    {
        Debug.Log(municaoAtual + "2 12");
        return this.municaoAtual;
    }

    public float GettamPente()
    {Debug.Log(tamPente + "3 12");
        return this.tamPente;
    }
}
