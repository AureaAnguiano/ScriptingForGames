using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplecharactercontroller : MonoBehaviour
{

    public float moveSpeed = 5f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        // Cache references to components
        controller = GetComponent<CharacterController>();
        thisTransform = thisTransform;

    }

    // Update is called once per frame
    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnXAxis();
    }

    private void MoveCharacter()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed  * Time.deltaTime);
        controller.Move(movementVector);
    }

    private void KeepCharacterOnXAxis()
    {
        // Use chached transform reference and optimize vector creation
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }

}
