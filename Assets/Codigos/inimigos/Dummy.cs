using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    private Animator animator;
    private float originalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
        Debug.Log("fui criado");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball") 
        {
            animator.SetBool("cai", true);
            Invoke("Destruir", 5f);
        }
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
