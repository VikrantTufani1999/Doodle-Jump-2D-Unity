﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Stand-Alone Player movement Controls


    //Declarations
    Rigidbody2D rb;
    Collider2D colliders;
    public float movementSpeed = 10f;
    private float movement = 0f;

    private bool facingLeft;

    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();           // Fetch rigidbody component
        colliders = GetComponent<Collider2D>();     // Fetch collider component
        facingLeft = true;          // bool variable for toggle purpose
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");           // Get Horizontal component
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        Flip(horizontal);           // Flips the character

        if (this.transform.position.y < -48f)            // End game if this is true.
        {
            EndScene();
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)              // Code to disable colliders if player hits enemies 
    {
        if(collision.gameObject.tag == "Enemy")
        {
            colliders.enabled = !colliders.enabled;
        }
               
    }

    void Flip(float horizontal)                 // Code to flip the character according to movement upwards.
    {
        if((movement/movementSpeed > 0 && facingLeft == true) || (movement/movementSpeed < 0 && facingLeft == false))
        {
            facingLeft = !facingLeft;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;                       

            transform.localScale = theScale;
        }
    }

    void EndScene()
    {
        SceneManager.LoadScene(2);
    }
}
