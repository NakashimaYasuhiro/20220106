using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    float speed = 3.0f;
    float jumpForce = 250.0f;
    private Animator animator;
    Vector3 playerPos;
    bool Ground = true;
    int key = 0;
    string state;
    string oldstate;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        playerPos = transform.position;
    }


    void Update()
    {
        Move();
        Statecheck();
        ChangeAnimation();

    }

    void Statecheck()
    {
        if (Ground)
        {
            if (key != 0)
            {
                state = "RUN";
            }
            else
            {
                state = "IDLE";
            }
        }
        else
        {
            state = "JUMP";
        }
    }

    void ChangeAnimation()
    {
        if (oldstate != state)
        {
            switch (state)
            {
                case "JUMP":
                    animator.SetBool("Jumping", true);
                    animator.SetBool("Running", false);
                    animator.SetBool("Idle", false);
                    break;
                case "RUN":
                    animator.SetBool("Jumping", false);
                    animator.SetBool("Running", true);
                    animator.SetBool("Idle", false);
                    break;
                default:
                    animator.SetBool("Jumping", false);
                    animator.SetBool("Running", false);
                    animator.SetBool("Idle", true);
                    break;
            }
            oldstate = state;
        }
    }

    void Move()
    {
        if (Ground)
        {
            if (CrossPlatformInputManager.GetButton("Jump"))
            {
                rb.AddForce(transform.up * jumpForce);
                Ground = false;
            }

        }
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        if (x != 0)
        {
            key = 1;
        }
        float y = CrossPlatformInputManager.GetAxis("Vertical");
        if (y != 0)
        {
            key = 1;
        }

        rb.MovePosition(transform.position + new Vector3(x * Time.deltaTime * speed, 0, y * Time.deltaTime * speed));

        Vector3 direction = transform.position - playerPos;


        if (direction.magnitude >= 0.01f && key == 1)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        }
        else
        {
            key = 0;
        }
        playerPos = transform.position;

    }

    void OnCollisionEnter(Collision other)
    {
        if (!Ground)
            Ground = true;

    }

}
