using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{

    public static playermanager instance { get; private set; }
    public GameObject player;
    public inputmanager inputManager;
    playerlocomotions playerLocomotion;
    public float movementSpeed;
    public float rotationSpeed;
    [Range(0, 100)]
    public Rigidbody rigidBody;

    private void Awake()
    {
        if (instance != null && instance != this) { Destroy(this); }
        else { instance = this; }
        inputManager = player.GetComponent<inputmanager>();
        playerLocomotion = player.GetComponent <playerlocomotions>();
        rigidBody = player.GetComponent <Rigidbody>();
    }

    private void Update()
    {
        inputManager.HandleAllInput();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }
}
