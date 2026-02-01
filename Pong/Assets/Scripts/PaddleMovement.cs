using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float input = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, input * speed * Time.deltaTime, 0);
    }
}