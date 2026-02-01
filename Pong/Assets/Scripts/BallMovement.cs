using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Private fields - hidden from other scripts
    private float speed = 3f;
    private Vector2 direction;
    private Rigidbody2D rb;

    // Public property with validation
    public float Speed
    {
        get { return speed; }
        set 
        { 
            if (value < 0)
            {
                speed = 0;
            }
            else
            {
                speed = value;
            }
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(1f, 1f).normalized;
        rb.linearVelocity = direction * speed;
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
        // Reverse horizontal direction when hitting paddles
        else if (collision.gameObject.name == "Left Paddle" || collision.gameObject.name == "Right Paddle")
        {
            direction.x = -direction.x;
        }
        
        // Apply the new direction to the rigidbody
        rb.linearVelocity = direction * speed;
    }
}