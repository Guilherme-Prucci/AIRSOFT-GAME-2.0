using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bola_Comportamento : MonoBehaviour
{
    private float backSpinDrag;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("Destroy_this", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadeAtual = rb.velocity.magnitude;
        rb.AddForce(backSpinDrag * Mathf.Sqrt(velocidadeAtual) * Time.deltaTime * transform.up);
    }

    private void Destroy_this()
    {
        Destroy(this.gameObject);
    }

    public void SetSpinDrag(float bsd)
    {
        this.backSpinDrag = bsd;
    }

    public void SetMass(float mass)
    {
        this.rb.mass = mass;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            Vector3 zero = Vector3.zero;
            rb.velocity = zero;
        }
    }

}
