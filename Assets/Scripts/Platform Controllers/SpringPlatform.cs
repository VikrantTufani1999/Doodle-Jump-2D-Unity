using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPlatform : MonoBehaviour
{
    public float jumpforce = 20f;           // force with which character bounces back after hitting platform
    //Animator springAnim;

    void Start()
    {
        //springAnim = GetComponent<Animator>();    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpforce;
                rb.velocity = velocity;
            }
        }

        if(collision.gameObject.tag == "Player")
        {
            //springAnim.SetBool("spring", true);
        }
    }
}
