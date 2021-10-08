using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    private Rigidbody rb;
    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        DoMove3D();
        DoJump3D();
    }

    void DoJump3D()
    {
        Vector3 velocity = rb.velocity;

        // check for jump
        if (Input.GetKey("z") && (isGrounded == true))
        {
            if (velocity.y < 0.01f)
            {
                velocity.y = 6f;

            }


        }




        rb.velocity = velocity;

    }










    void DoMove3D()
    {
        Vector3 velocity = rb.velocity;

        velocity.x = 0;

        if (Input.GetKey("d"))
        {
            velocity.x = -5;
        }

        if (Input.GetKey("a"))
        {
            velocity.x = 5;
        }

        if (Input.GetKey("s"))
        {
            velocity.z = 5;
        }

        if (Input.GetKey("w"))
        {
            velocity.z = -5;
        }


        rb.velocity = velocity;
    }



    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }




}
