using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBox : MonoBehaviour
{

    public float rotatingSpead;
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.y += rotatingSpead;
        transform.eulerAngles = rotation;
    }
}
