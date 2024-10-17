using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagShotgun : MonoBehaviour
{
    public GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        int tipo = Random.Range(0, 3);
        if (other.tag.Equals("Player"))
        {
            controller.GetComponent<TipoMunicao>().ColetouMunicao(tipo, 8f);
        }
    }
}
