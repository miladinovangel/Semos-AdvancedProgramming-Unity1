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
    }

    private void FixedUpdate() // na sekoj update na physics engine - 0.02
    {
        rb.velocity = new Vector3(0f, 0f, speed);
    }
}


// imame nov objekt koj sto player-ot treba da moze da go sobere
// koga ke go sobere, dobiva 20% pogolema brzina na 3 sekundi
// kockata treba da ja napravite bavno da se rotira