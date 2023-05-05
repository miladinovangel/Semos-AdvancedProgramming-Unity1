using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ENCAPSULACIJA - 

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField] // ovozmozuva private promenlivi da se menuvaat/gledaat vo inspektorot
    private float speed = 10;
    [SerializeField]
    private int health = 100;
    [SerializeField]
    protected float jumpForce = 1;
    [SerializeField]
    protected Rigidbody rb;

    public void Move() // dvizenje
    {
        Vector3 position = transform.position;
        position.z -= speed * Time.deltaTime;
        transform.position = position;
    }

    public virtual void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    private void Die()
    {
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }

    private void DecreaseHealth()
    {
        health--;
        if (health == 0)
        {
            Die();
        }
    }
}
