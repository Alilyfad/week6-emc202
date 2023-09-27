using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputmanager : MonoBehaviour
{

    private Playercontrols playercontrols;
    private Vector2 movementInput;
    private float verticalInput;
    private float horizontalInput;

    private void OnEnable()
    {
        if (playercontrols == null)
        {
            playercontrols = new Playercontrols();
            //when we hit WASD, we will record the movement to a variable
            playercontrols.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playercontrols.Enable();
    }

    public void OnDisable()
    {
        playercontrols.Disable();
    }

    public void HandleAllInput()
    {
        HandleMovementInput();
    }

    public void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
