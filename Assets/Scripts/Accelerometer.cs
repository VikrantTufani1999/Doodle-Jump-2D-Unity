using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Accelerometer : MonoBehaviour
{
    // Declarations
    public bool isFlat = true;          // If device is laying flat 
    private Rigidbody2D rigid;          // Fetch rigidbody component
    float moveSpeed = 10f;
    bool facingLeft;

    Collider2D colliders;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();    // Fetch Rigidbody component
        colliders = GetComponent<Collider2D>();         // Fetch collider component
        facingLeft = true;          // Toggle (Not working)
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");       // Get Horizontal component 

        Flip(horizontal);           // Calling the flip function


        //  Code to move player according to device motion control 
        Vector3 tilt = Input.acceleration;              
        tilt.x = tilt.x * moveSpeed;

        if (isFlat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }

        if (transform.position.x < -3)
        {
            transform.position = new Vector2(3, transform.position.y);
        }

        else if (transform.position.x > 3)
        {
            transform.position = new Vector2(-3, transform.position.y);
        }

        rigid.AddForce(tilt);

        if(this.transform.position.y < -48f)            // End game if this is true.
        {
            LoadEndScene();
        }
    }

    void Flip(float horizontal)             // Function to flip character (_Not functional_)
    {
        if ((horizontal > 0 && facingLeft == true) || (horizontal < 0 && facingLeft == false))
        {
            facingLeft = !facingLeft;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)          
    {   
        if (collision.gameObject.tag == "Enemy")            // Collision detection with enemy
        {
            colliders.enabled = !colliders.enabled;
            Invoke("LoadEndScene()", 2f);                       // Actions on collision with enemy
        }
    }

    void LoadEndScene()
    {
        SceneManager.LoadScene(2);                      // Load GameOver Scene. 
    }
}
