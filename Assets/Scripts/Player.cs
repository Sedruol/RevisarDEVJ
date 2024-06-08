using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float rightForce;
    float leftForce;
    public float velocity = 0.01f;
    Vector3 newVelocity = Vector3.zero;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            rightForce = -1;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            rightForce = 0;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            leftForce = 1;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            leftForce = 0;
        }
        newVelocity.x = (rightForce + leftForce) * velocity;
        this.transform.position += newVelocity;
    }
}
