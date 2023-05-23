using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        // treba da se unisti enemy
        //Destroy(other.gameObject);

        // treba da se unisti kursumot
        if (other.gameObject.tag == "Enemy")
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
        Destroy(gameObject.transform.parent.gameObject);
    }
}
