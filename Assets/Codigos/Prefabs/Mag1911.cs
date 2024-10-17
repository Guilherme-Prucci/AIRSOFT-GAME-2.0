using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mag1911 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject controller;

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
            controller.GetComponent<TipoMunicao>().ColetouMunicao(tipo, 12f);
        }
        Destroy(this.gameObject);
    }
}
