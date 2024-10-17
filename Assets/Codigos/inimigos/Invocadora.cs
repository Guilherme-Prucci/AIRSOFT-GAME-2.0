using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Invocadora : MonoBehaviour
{
    public GameObject dummy;


    private Transform[] ninho;
    // Start is called before the first frame update
    void Start()
    {
        ninho = GetComponentsInChildren<Transform>();
        for(int i = 0; i < ninho.Length; i++)
        {
            Instantiate(dummy, ninho[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
