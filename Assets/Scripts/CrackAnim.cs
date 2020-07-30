using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackAnim : MonoBehaviour
{
    [SerializeField] private Animator crackAnim;                // Animation Controller goes here.
    private bool isSecond = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isSecond = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && isSecond == true)
        {
            crackAnim.SetBool("crack", true);               // Triggers Platform cracking animation 
            isSecond = false;
            Destroy(gameObject, 1f);                        // Destroy gameobject after animation is over.
        }
    }
}
