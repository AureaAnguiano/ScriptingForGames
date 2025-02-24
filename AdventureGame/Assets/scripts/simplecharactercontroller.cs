using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterAnimationController))]
public class simplecharactercontroller : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float JumpForce = 8f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;

    private Vector3 movementVector = Vector3.zero;

    // Start is called before the first frame update
   private void Start()
    {
        
        controller = GetComponent<CharacterController>();
        thisTransform = transform;

    }

    // Update is called once per frame
    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnXAxis();
        ApplyGravity();
       
        

    }

    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move =  new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);

        //jumping
        if(Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpForce * -2f * gravity);
        }
    }
    
    private void ApplyGravity()
    {
        //apply gravity when not grounded
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0f; // resets velocity when grounded
        }
        //apply the velocity to the controller
        controller.Move(velocity * Time.deltaTime);
    }
        
        
        
            
        
        
    
    private void KeepCharacterOnXAxis()
    {
        //Use chached transform reference and optimize vector creation
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }

}
