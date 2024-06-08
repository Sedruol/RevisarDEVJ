using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlatform : MonoBehaviour
{
    public float runSpeed = 5f;//empece con 2
    public float jumpSpeed = 3f;
    Rigidbody2D rb;//freezear la rotacion en el rb en unity
    //DASH
    public float velocityDash;
    public float durationDash;
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
        if (Input.GetKeyDown(KeyCode.Space) && CheckGround.isGrounded)
        {
            jumping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canDoubleJump)
        {
            doubleJump = true;
        }
    }
    private void FixedUpdate()
    {
        if (dashing == false)
        {
            //physics material 2D para evitar problemas
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    dashing = true;
                    rb.velocity = new Vector2(10, rb.velocity.y);
                    dashing = false;
                }
                else
                {
                    rb.velocity = new Vector2(runSpeed, rb.velocity.y);
                }
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-runSpeed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
            //jumping
            if (jumping)
            {
                jumping = false;
                canDoubleJump = true;
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }
            if (doubleJump)
            {
                doubleJump = false;
                canDoubleJump = false;
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }
        }
        //DASH
        if (Input.GetKey(KeyCode.Z) && dashing==false && CheckGround.isGrounded)
        {
            dashing = true;
            rb.velocity = new Vector2(10, rb.velocity.y);
            dashing = false;
        }
    }
}