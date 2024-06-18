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
    public float hp = 100f;
    public float healing = 15f;
    public void LoseHP(float dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            Debug.Log("perdiste manco");
        }
    }
    public void GainHP(float healing)
    {
        if (hp + healing >= 100)
        {
            hp = 100;
            Debug.Log("hp: " + hp);
        }
        else if (hp > 0 && hp + healing <= 100)
        {
            hp += healing;
            Debug.Log("hp: " + hp);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Healing"))
        {
            GainHP(healing);
            Destroy(collision.gameObject);
        }
    }
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