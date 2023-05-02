using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int speed = 1;
    public float rotationSpeed = 0.5f;
    //public Vector2 direction = Vector2.right;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(false);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotate();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            
        }
        // so drzenje left i right arrow, objektot da se rotira na levo/desno
        //transform.eulerAngles

        //transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        // koga ke drzite na strelkata nagore, enemy objektot da se dvizi napred
        //Move();
    }

   

    private void Move(bool moveForward)
    {
        Vector3 position = transform.position;
        position.z -= speed * Time.deltaTime;
        transform.position = position;
    }
    private void Rotate()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.y -= rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }


    // kodot so dvizenje stavete go vo funkcija Move
}
