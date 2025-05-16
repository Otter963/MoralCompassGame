using System;
using UnityEngine;
using UnityEngine.InputSystem;

/*Reference:
Title: FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial 
Author: Dave / GameDevelopment
Date: 2022, February 7
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=f473C43s8nE
*/

/*Reference:
Title: Sprinting | Simple Character Controller in Unity | Part 9 [Video]
Author: chonk
Date: 2023, September 16
Code version: 6000.0.42f1
Availability: https://www.youtube.com/watch?v=CRt4XvXAYrU
*/

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed;

    [SerializeField] private float groundDrag;

    [Header("Ground Check")]
    [SerializeField] private float playerHeight;
    [SerializeField] private LayerMask whatIsGround;
    private bool isGrounded;

    [SerializeField] private Transform orientation;

    float horInput;
    float vertInput;

    Vector3 moveDirection;

    Rigidbody playerRB;

    [Header("Sprinting")]
    [SerializeField] private Movement movement;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //making sure the player doesn't fall over
        playerRB.freezeRotation = true;
    }

    private void Update()
    {
        //ground checking
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        PlayerInput();
        SpeedControl();

        //applying drag
        if (isGrounded )
        {
            playerRB.linearDamping = groundDrag;
        }
        else
        {
            playerRB.linearDamping = 0;
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void PlayerInput()
    {
        horInput = Input.GetAxisRaw("Horizontal");
        vertInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //applying current speed with sprinting
        var targetSpeed = movement.isSprinting ? movement.speed * movement.multiplier : movement.speed;
        movement.currentSpeed = Mathf.MoveTowards(movement.currentSpeed, targetSpeed, movement.acceleration * Time.deltaTime);

        //calculating movement direction to move in direction looking only
        moveDirection = orientation.forward * vertInput + orientation.right * horInput;

        playerRB.AddForce(moveDirection.normalized * movement.currentSpeed * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVelocity = new Vector3(playerRB.linearVelocity.x, 0f, playerRB.linearVelocity.z);

        //limit velocity if needed
        if (flatVelocity.magnitude > moveSpeed)
        {
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            playerRB.linearVelocity = new Vector3(limitedVelocity.x, playerRB.linearVelocity.y, limitedVelocity.z);
        }
    }

    public void Sprint(InputAction.CallbackContext context)
    {
        movement.isSprinting = context.started || context.performed;
    }
}

//the sprinting stuff
[Serializable]
public struct Movement
{
    public float speed;
    public float multiplier;
    public float acceleration;

    [HideInInspector] public bool isSprinting;
    [HideInInspector] public float currentSpeed;
}
