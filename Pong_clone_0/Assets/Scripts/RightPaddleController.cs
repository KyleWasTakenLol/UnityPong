using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleController : PaddleController, ICollidable
{
    protected override float GetMovementInput()
    {
        return Input.GetAxis("RightPaddle");
    }

    public void OnHit(Collision2D collision)
    {
        // Paddle's response to being hit
        Debug.Log("Right Paddle was hit!");
    }
}