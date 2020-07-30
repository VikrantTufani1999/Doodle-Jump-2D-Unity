using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInvisiblePlatformController : MonoBehaviour
{
    [SerializeField] float jumpforce = 10f;         // Player bouncing back force after hitting platform

    void OnCollisionEnter2D(Collision2D collision)          // Code for Player jumps after hitting platform
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
            gameObject.SetActive(false);
            //Set current Platform Inactive.
        }
    }
}
