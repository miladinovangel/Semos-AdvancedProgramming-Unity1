using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        //Vector3 pos = transform.position;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
