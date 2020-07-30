using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Does not work perfectly when device motion control movement is attached to the character

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform shooter; 
    [SerializeField] private GameObject bullet;

    private Vector2 lookDirection;
    private float lookAngle;

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        if(lookAngle > 90f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if(Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            
        }

    }

    private void FireBullet()
    {
        GameObject fireBullet = Instantiate(bullet, shooter.position, shooter.rotation);
        fireBullet.GetComponent<Rigidbody2D>().velocity = shooter.up * 10f;
    }
}
