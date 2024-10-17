using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola1911 : MonoBehaviour
{
    public GameObject controller;
    public float municaoAtual = 12f;
    public float tamPente = 12f;
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
        Debug.Log(municaoAtual + "1 p1");
        this.municaoAtual = municaoAtual;
    }

    public float GetmunicaoAtual()
    {
        Debug.Log(municaoAtual + "2 p1");
        return this.municaoAtual;
    }

    public float GettamPente()
    {
        Debug.Log(tamPente + "3 p1");
        return this.tamPente;
    }
}
