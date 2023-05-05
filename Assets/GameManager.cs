using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BaseEnemy enemy;
    public bool toa = false;

    // koga ke klikneme na kopceto play, da pocneme od ovde da ja povikuvame funkcijata Move od enemy
    private void Update()
    {
        if (toa)
        {
            enemy.Move();
        }

        // testirame skokanje
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemy.Jump();
        }
    }

    public void PlayPressed()
    {
        toa = true;
    }
}
