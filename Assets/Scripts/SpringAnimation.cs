using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringAnimation : MonoBehaviour
{
    Animator springAnim;


    void Start()
    {
        springAnim = GetComponent<Animator>();    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            springAnim.SetBool("spring", true);
        }
    }

    
}
