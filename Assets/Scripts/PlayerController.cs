using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public bool canMove = true; // 允许移动的开关

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (canMove) // 只有当 canMove 为 true 时，玩家才能移动
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Vector2.zero; // 停止移动
        }
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            rb.velocity = movement * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
