using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int speed = 1;
    public float rotationSpeed = 0.5f;


    void Update()
    {
        Move();
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    Move();
        //}
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    Move();
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Rotate(false);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Rotate(true);
        //}
        // so drzenje left i right arrow, objektot da se rotira na levo/desno
        //transform.eulerAngles

        //transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        // koga ke drzite na strelkata nagore, enemy objektot da se dvizi napred
        //Move();
    }
   

    public virtual void Move()
    {
        Vector3 position = transform.position;
        position.z -= speed * Time.deltaTime;
        transform.position = position;
    }

    private void Rotate(bool rotateLeft)
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.y += (rotateLeft ? -1 : 1) * rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }


    // kodot so dvizenje stavete go vo funkcija Move
}


// 2 del od parcijalnata klasa PartialClassTest
//partial class PartialClassTest
//{
//    public int pt3;

//    public void Test()
//    {

//    }
//}