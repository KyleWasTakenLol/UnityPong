using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleController : PaddleController
{
    protected override float GetMovementInput()
    {
        float input = Input.GetAxis("RightPaddle");
        return input;
    }
}