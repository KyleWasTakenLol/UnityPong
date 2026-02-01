using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    protected float speed = 5f;
    protected Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float input = GetMovementInput();
        rb.linearVelocity = new Vector2(0, input * speed);
    }

    protected virtual float GetMovementInput()
    {
        return 0f;
    }
}