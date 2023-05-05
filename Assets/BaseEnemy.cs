using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    public float speed = 10;
    public int health = 100;
    public float jumpForce = 1;
    public Rigidbody rb;

    public void Move() // dvizenje
    {
        Vector3 position = transform.position;
        position.z -= speed * Time.deltaTime;
        transform.position = position;
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    public void Die()
    {
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }

    public void DecreaseHealth()
    {
        health--;
        if (health == 0)
        {
            Die();
        }
    }
}
