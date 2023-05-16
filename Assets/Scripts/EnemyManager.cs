using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// polymorphism - poly - mnogu, morphism - formi

public class EnemyManager : MonoBehaviour
{
    //[SerializeField]
    //private TeleportingEnemy tpEnemy;
    //[SerializeField]
    //private BlinkingEnemy blinkEnemy;
    //[SerializeField]
    //private ScalingEnemy scalingEnemy;
    [SerializeField]
    private BaseEnemy[] enemies;
    [SerializeField]
    private Transform player;

    private bool gameStarted = false;

    // koga ke klikneme na kopceto play, da pocneme od ovde da ja povikuvame funkcijata Move od enemy
    private void Update()
    {
        if (gameStarted)
        {
            //tpEnemy.Move();
            //blinkEnemy.Move();
            //scalingEnemy.Move();
            for (int i = 0; i < enemies.Length; i++)
            {
                //if (enemies[i] != null)
                 enemies[i].Move(player.position);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].Jump();
                }
            }
        }
    }

    public void PlayPressed()
    {
        gameStarted = true;
    }
}
