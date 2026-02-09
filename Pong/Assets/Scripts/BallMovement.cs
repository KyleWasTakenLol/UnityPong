using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour, ICollidable
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
        // Check if the object we hit implements ICollidable
        ICollidable collidable = collision.gameObject.GetComponent<ICollidable>();
        
        if (collidable != null)
        {
            // Object has the interface, notify it that it was hit
            collidable.OnHit(collision);
        }
        else
        {
            // Object doesn't have ICollidable, handle collision directly
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
            
            // Apply the new direction
            rb.linearVelocity = direction * speed;
        }
    }
    public void OnHit(Collision2D collision)
    {
        // Ball's response to being hit by paddles
        direction.x = -direction.x;
        rb.linearVelocity = direction * speed;
    }
}