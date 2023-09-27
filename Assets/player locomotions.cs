using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlocomotions : MonoBehaviour
{

    private Vector3 moveDirection;
    private Transform cameraObject;
    


    private void Awake()
    {
        cameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {
        moveDirection = cameraObject.forward * playermanager.instance.inputManager.verticalInput;
        moveDirection = moveDirection + cameraObject.right * playermanager.instance.inputManager.horizontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection *= playermanager.instance.movementSpeed;
        Vector3 MovementVelocity = moveDirection;
        playermanager.instance.rigidBody.velocity = MovementVelocity; 
    }

    private void HandleRotation()
    {
        Vector3 targetDirection = Vector3.zero;
        targetDirection = cameraObject.forward * playermanager.instance.inputManager.verticalInput;
        targetDirection = targetDirection + cameraObject.right * playermanager.instance.inputManager.horizontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation =
            Quaternion.Slerp

            (
                transform.rotation, targetRotation, playermanager.instance.rotationSpeed
            );
        transform.rotation = playerRotation;  
    }
}
