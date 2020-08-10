using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Animator explosion;            // Animation Controller goes here.

    private void Start()
    {
        explosion = GetComponent<Animator>();           // Fetch reference
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            explosion.SetTrigger("Explosion");                      // Trigger Explosion Animation
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            explosion.SetTrigger("Explosion");                      // Trigger Explosion Animation
        }
    }

    private void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);        // Code for back-forth motion of Enemy Characters.
    }
}
