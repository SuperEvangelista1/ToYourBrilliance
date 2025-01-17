using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the player
    private Rigidbody2D rb; // Rigidbody2D component to move the player
    private Vector2 moveDirection; // Direction to move based on input

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input for horizontal and vertical movement
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D or Arrow Left/Right
        float moveY = Input.GetAxisRaw("Vertical");   // W/S or Arrow Up/Arrow Down

        // Ensure that the player only moves in one direction at a time
        if (moveX != 0)
        {
            moveDirection = new Vector2(moveX, 0); // Move left or right
        }
        else if (moveY != 0)
        {
            moveDirection = new Vector2(0, moveY); // Move up or down
        }
        else
        {
            moveDirection = Vector2.zero; // No movement when no key is pressed
        }
    }

    void FixedUpdate()
    {
        // Move the player based on the calculated direction
        rb.velocity = moveDirection * moveSpeed;
    }
}
