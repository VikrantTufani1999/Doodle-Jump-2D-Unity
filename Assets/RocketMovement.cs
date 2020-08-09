using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Animator rocket;
    [SerializeField] GameObject player;
    public bool isHit = false;

    Vector3 offset = new Vector3(0.1f, 0.2f, 0);

    private void Start()
    {
        rocket = GetComponent<Animator>();
    }

    private void Update()
    {
        //Debug.Log(player.transform.position);
        if (isHit == true)
        {
            this.transform.position = player.transform.position + offset;
            

            if (player.transform.position.x > 0)
            {
                offset = new Vector3(0.1f, 0.2f, 0);
            }
            else
            {
                offset = new Vector3(-0.1f, 0.2f, 0);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            rocket.SetBool("rocket", true);
            isHit = true;

            Destroy(this.gameObject, 3f);
        }
    }
}
