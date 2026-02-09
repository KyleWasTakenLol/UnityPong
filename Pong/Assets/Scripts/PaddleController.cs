using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PaddleController : MonoBehaviour
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

    protected abstract float GetMovementInput();
}