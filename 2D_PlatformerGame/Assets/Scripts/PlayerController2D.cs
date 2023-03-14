using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("Player States")] // great way to organize variables in the inspector in Unity.
    public float speed;
    public float jumpForce;
    private float moveInput;

    [Header("Rigidbody Component")]
    private Rigidbody2D rb;
    private bool isFacingRight = true;

    [Header("Player Jump Settings")]
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool doubleJump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Gets Rigidbody reference (that component is attatched to the player too)
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); // Define what is ground.
        moveInput = moveInput.GetAxis("Horizontal"); // Get teh Horizontal keybinding which will return a value between -1 and 1.
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); // Move the player left and right.

        if (!isFacingRight && moveInput > 0)
        {
            FlipPlayer();
        }
        else if (isFacingRight && moveInput < 0)
        {
            FlipPlayer();
        }
    }

    void FlipPlayer()
    {
        isFacingRight + !isFacingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1; //Flips the sprite graphic around
        transform.localScale = scaler;
    }

    void Update()
    {
        if (isGrounded) // isGrounded means true, !isGrounded would mean not true.
        {
            doubleJump = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce;
            doubleJump = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
