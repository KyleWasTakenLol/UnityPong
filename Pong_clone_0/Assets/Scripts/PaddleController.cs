using UnityEngine;
using Unity.Netcode;

public abstract class PaddleController : NetworkBehaviour
{
    protected float speed = 8.0f;
    protected Rigidbody2D paddle;

    void Start() {
        paddle = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {

        if (IsOwner)
        {
        float input = GetMovementInput();
        float currentSpeed = speed;
        paddle.linearVelocity = new Vector2(0, input * currentSpeed);
        }
    }

    //Get input function
    protected abstract float GetMovementInput();
}