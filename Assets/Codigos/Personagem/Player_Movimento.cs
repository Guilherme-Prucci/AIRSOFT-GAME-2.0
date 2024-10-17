using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movimento : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 foward;
    private Vector3 strafe;
    private Vector3 vertical;
    private Vector3 finalVelocity;

    private float fowardSpeed = 7f;
    private float strafeSpeed = 5f;
    private float fowardInput;
    private float strafeInput;

    public float gravity = 10f;
    public float jumpSpeed = 2f;
    public float timeMaxJump = 0.5f;

    private float timeOfJump;

    private bool jumping = false;

    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            jumping = true;
            timeOfJump = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.Space) || Time.time - timeOfJump >= timeMaxJump)
        {
            jumping = false;
        }

        if (vertical.y > 0 && (controller.collisionFlags & CollisionFlags.Above) != 0)
        {
            vertical = Vector3.zero;
        }

        fowardInput = Input.GetAxisRaw("Vertical");
        strafeInput = Input.GetAxisRaw("Horizontal");


    }

    private void FixedUpdate()
    {
        foward = fowardInput * fowardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        controller.Move(finalVelocity * Time.deltaTime);
        finalVelocity = foward + strafe + vertical;

        vertical += gravity * Time.deltaTime * Vector3.up;
        if (controller.isGrounded)
        {
            vertical = Vector3.down;
        }

        if (jumping)
        {
            vertical = jumpSpeed * Vector3.up;
        }
    }
}
