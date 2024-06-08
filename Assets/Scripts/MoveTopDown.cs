using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTopDown : MonoBehaviour
{
    float rightForce;
    float leftForce;
    float upForce;
    float downForce;
    public float velocity = 0.01f;
    Vector3 newVelocity = Vector3.zero;
    void Update()
    {
        //KeyCode.RightArrow
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            rightForce = -1;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            rightForce = 0;
        }
        //KeyCode.LeftArrow
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            leftForce = 1;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            leftForce = 0;
        }
        //KeyCode.UpArrow
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {
            upForce = 1;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            upForce = 0;
        }
        //KeyCode.DownArrow
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {
            downForce = -1;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            downForce = 0;
        }
        newVelocity.x = (rightForce + leftForce) * velocity;
        newVelocity.y = (upForce + downForce) * velocity;
        this.transform.position += newVelocity;
    }
}