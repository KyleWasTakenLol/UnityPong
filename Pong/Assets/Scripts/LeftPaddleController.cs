using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleController : PaddleController
{
    protected override float GetMovementInput()
    {
        float input = Input.GetAxis("LeftPaddle");
        return input;
    }
}