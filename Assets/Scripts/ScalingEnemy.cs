using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingEnemy : BaseEnemy
{
    [SerializeField]
    private float scalingSpeed = 2;

    private void Update()
    {
        Scale();
    }
    public void Scale()
    {
        Vector3 scale = transform.localScale;
        scale.x += scalingSpeed * Time.deltaTime;
        transform.localScale = scale;
    }
}
