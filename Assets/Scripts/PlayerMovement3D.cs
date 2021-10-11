using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    private Rigidbody rb;
    private bool isGrounded;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
        velocity.z = 0;

        if (Input.GetKey("d"))
        {
            velocity.x = 5;
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKey("a"))
        {
            velocity.x = -5;
            transform.localRotation = Quaternion.Euler(0, 270, 0);
        }

        if (Input.GetKey("s"))
        {
            velocity.z = -5;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey("w"))
        {
            velocity.z = 5;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (velocity.z > 1 || velocity.z < -1 || velocity.x > 1 || velocity.x < -1 )
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
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
