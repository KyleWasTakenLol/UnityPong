using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleController : PaddleController, ICollidable
{
    protected override float GetMovementInput()
    {
        return Input.GetAxis("LeftPaddle");
    }

    public void OnHit(Collision2D collision)
    {
        // Paddle's response to being hit
        Debug.Log("Left Paddle was hit!");
    }
}