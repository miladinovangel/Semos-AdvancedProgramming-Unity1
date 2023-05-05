using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TeleportingEnemy tpEnemy;
    [SerializeField]
    private BlinkingEnemy blinkEnemy;

    private bool gameStarted = false;

    // koga ke klikneme na kopceto play, da pocneme od ovde da ja povikuvame funkcijata Move od enemy
    private void Update()
    {
        if (gameStarted)
        {
            tpEnemy.Move();
            blinkEnemy.Move();
        }

        // testirame skokanje
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    tpEnemy.Jump();
        //}
    }

    public void PlayPressed()
    {
        gameStarted = true;
    }
}
