using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_controle : MonoBehaviour
{
    public Game_Controller controller;

    public Transform firePoint;
    public GameObject ball;

    public float forcaMola = 500f;
    public float backSpinDrag = 10f;
    private bool Shooting = false;
    private float massaBola = 0.2f;

    private float backSpinDragInstace;
    private GameObject ballInstace;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && controller.GetComponent<Game_Controller>().Municao_No_Pente() && !controller.GetComponent<Game_Controller>().Getreloading())
        {
            Shooting = true;
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            backSpinDrag += Input.GetAxis("Mouse ScrollWheel") * 10f;
            
            //controller.GetComponent<Textos>().SetBackSpinDragHud(backSpinDrag);
        }

        if (Input.GetKeyDown(KeyCode.R)){
            controller.GetComponent<Game_Controller>().Recarregar();
        }
    }

    private void FixedUpdate()
    {
        if (Shooting)
        {
            ballInstace = Instantiate(ball, firePoint.transform.position, firePoint.transform.rotation);
            Shooting = false;
            ballInstace.GetComponent<Rigidbody>().AddForce(transform.forward * forcaMola);
            backSpinDragInstace = backSpinDrag;
            ballInstace.GetComponent<Bola_Comportamento>().SetSpinDrag(backSpinDragInstace);
            ballInstace.GetComponent<Bola_Comportamento>().SetMass(massaBola);
            controller.GetComponent<Game_Controller>().Atirou();
        }
    }

    public void MudarMassa (float massa)
    {
        massaBola = massa;
    }
}
