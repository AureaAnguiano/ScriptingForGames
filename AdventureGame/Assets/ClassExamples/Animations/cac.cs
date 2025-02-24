using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cac : MonoBehaviour
{
    private Animator animator;
    public CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        animator =  GetComponent<Animator>();
        controller = GetComponentInParent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()

    {
        //running and idling

        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");

        }
        //jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
        //wall jumping
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }

        //triggers the double jump animation
        //if (Input.GetButtonDown("Jump"))
        //{
            //animator.SetTrigger("Jump");
        //}
        //else
        //{
            //animator.SetTrigger("Idle");
        //}

        //Triggers the hit animation
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        //triggers fall animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
        else
        {
            animator.SetTrigger("Idle");

        }
    }
}
   

