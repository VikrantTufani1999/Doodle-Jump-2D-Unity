using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPlatformController : MonoBehaviour
{
    [SerializeField] float jumpForceValue1 = 10f;       // Player bouncing back force after hitting platform

    private void Update()
    {

        transform.position = new Vector3(Mathf.PingPong(Time.time, 1.5f), transform.position.y , transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision)              // Code for Player jumps after hitting platform
    {
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForceValue1;
                rb.velocity = velocity;
            }
        }
    }
}
