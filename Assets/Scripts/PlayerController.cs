using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform bulletSpawnPosition;

    void Update()
    {
        // kako da implementirame dvizenje
        //Input.GetAxis("Horizontal");
        //Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //bulletPrefab.transform.position = transform.position;
            GameObject bulletInstance = Instantiate(bulletPrefab); // kreirame instanca od objektot bullet prefab
            bulletInstance.transform.position = bulletSpawnPosition.position;
        }


    }
    void ResetSpeed ()
    {
        speed /= 1.2f;
    }
    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "RotatingBox")
        {
            Destroy(other.gameObject);
            speed *= 1.2f;
            Invoke("ResetSpeed", 3f);
        }
        
      
    }
}
