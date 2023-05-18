using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private Rigidbody rb;

    private void Start()
    {
        Destroy(gameObject, 5f);
        //Invoke("DestroySelf", 5f); // drug nacin kako moze da se samounisti kursumot
    }

    //private void DestroySelf()
    //{
    //    Destroy(gameObject);
    //}

    //private void Update() // na sekoj frame - Time.deltaTime
    //{
    //    Move();
    //}

    private void FixedUpdate() // na sekoj update na physics engine - 0.02
    {
        rb.velocity = new Vector3(0f, 0f, speed);
    }

    //private void Move()
    //{
    //    //Vector3 pos = transform.position;
    //    //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    //}
}


// imame nov objekt koj sto player-ot treba da moze da go sobere
// koga ke go sobere, dobiva 20% pogolema brzina na 3 sekundi
// kockata treba da ja napravite bavno da se rotira