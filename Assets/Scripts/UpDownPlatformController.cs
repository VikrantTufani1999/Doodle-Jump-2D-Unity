using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownPlatformController : MonoBehaviour
{
    [SerializeField] float jumpForceValue = 10f;        // Player bouncing back force after hitting platform

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 3), transform.position.z);         // I think this line is problem in y position error.
    }

        void OnCollisionEnter2D(Collision2D collision)                      // Code for Player jumps after hitting platform
        {
            if (collision.relativeVelocity.y <= 0)
            {
                Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForceValue;
                    rb.velocity = velocity;
                }
            }
        }
    }

