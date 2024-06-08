using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTopDown : MonoBehaviour
{
    float movX;
    float movY;
    public float speed = 3f;
    Rigidbody2D rb;//freezear la rotacion en el rb en unity
    public float velocityDash = 25f;
    public bool dashing = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
        movY = Input.GetAxisRaw("Vertical");
        //DASH
        if (Input.GetKeyDown(KeyCode.Z) && dashing == false)
        {
            dashing = true;
        }
    }
    private void FixedUpdate()
    {
        //dashing
        if (dashing)
        {
            dashing = false;
            rb.velocity = new Vector2(velocityDash * movX, movY * velocityDash);
        }
        else
        {
            rb.velocity = new Vector2(movX * speed, movY * speed);
        }
    }
}