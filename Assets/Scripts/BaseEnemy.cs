using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ENCAPSULACIJA - koncept vo objektno orientirano programiranje koj ni ukazuva deka site
// klasi treba da bidat zatvoreni kolku sto e mozno poveke

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


    public virtual void Move(Vector3 targetPosition) // dvizenje
    {
        //Vector3 position = transform.position;
        //position.z -= speed * Time.deltaTime;
        //transform.position = position;

        // logika sto ke go dvizi ovoj enemy objekt kon pozicijata moveTowards
        Vector3 position = transform.position;
        position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
        transform.position = position;

        //Vector3.Distance() - funkcija koja vraka rastojanie pomegu 2 objekti/vektori
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
