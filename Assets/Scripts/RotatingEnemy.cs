using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingEnemy : BlinkingEnemy
{
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.y += 0.01f;
        transform.eulerAngles = rotation;
    }
}
