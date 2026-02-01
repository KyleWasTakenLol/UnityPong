using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(3f, 3f);
        rb.linearVelocity = direction;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reverse vertical direction for top and bottom walls
        if (collision.gameObject.name == "Top Wall" || collision.gameObject.name == "Bottom Wall")
        {
            direction.y = -direction.y;
        }
        // Reverse horizontal direction for left and right walls
        else if (collision.gameObject.name == "Left Wall" || collision.gameObject.name == "Right Wall")
        {
            direction.x = -direction.x;
        }
        
        // Apply the new direction to the rigidbody
        rb.linearVelocity = direction;
    }
}