using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOfEnemy : MonoBehaviour
{
    [SerializeField]
    private float speed = -1f;
    [SerializeField]
    private Rigidbody rb;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void FixedUpdate() // na sekoj update na physics engine - 0.02
    {
        rb.velocity = new Vector3(0f, 0f, speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("BulletOfEnemy:OnCollision enter");
        Destroy(gameObject);
    }
}
