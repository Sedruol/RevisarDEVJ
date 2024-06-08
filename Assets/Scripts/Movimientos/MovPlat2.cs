using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlat2 : MonoBehaviour
{
    float movX;
    public float runSpeed = 7.5f;//empece con 2
    public float jumpSpeed = 7.5f;//empece con 3
    Rigidbody2D rb;//freezear la rotacion en el rb en unity
    public float velocityDash = 10f;
    public bool dashing = false;
    public bool jumping = false;
    public static bool canDoubleJump = false;
    public bool doubleJump = false; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
        Debug.Log(movX);
        //JUMP
        if (Input.GetKeyDown(KeyCode.Space) && CheckGround.isGrounded)
        {
            jumping = true;
        }
        //DASH
        if (Input.GetKeyDown(KeyCode.Z) && dashing == false && CheckGround.isGrounded)
        {
            dashing = true;
        }
        //DOUBLE JUMP
        if (Input.GetKeyDown(KeyCode.Space) && canDoubleJump)
        {
            doubleJump = true;
        }
    }
    private void FixedUpdate()
    {
        //dashing
        if (dashing)
        {
            dashing = false;
            rb.velocity = new Vector2(velocityDash * rb.velocity.x, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(movX * runSpeed, rb.velocity.y);
            //jumping
            if (jumping)
            {
                jumping = false;
                canDoubleJump = true;
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }
            else if (doubleJump)
            {
                doubleJump = false;
                canDoubleJump = false;
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }
        }
    }
}