using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoInvisblePFController : MonoBehaviour
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Invoke("SetInactive", 0.5f);
        }
    }

    void SetInactive()
    {
        //Debug.Log("Set Object inactive");
        this.gameObject.SetActive(false);
    }
}
