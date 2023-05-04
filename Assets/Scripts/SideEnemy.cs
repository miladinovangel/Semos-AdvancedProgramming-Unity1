using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideEnemy : Enemy
{
    // ovde da napravite override na funkcijata Move i za SideEnemy da implementirate logika za dvizenje na levo
    public override void Move()
    {
        base.Move();// call base Move 

        // ekstra logika za dvizenje
        Vector3 position = transform.position;
        position.x -= speed * Time.deltaTime;
        transform.position = position;
    }
}
