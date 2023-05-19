using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// polymorphism - poly - mnogu, morphism - formi

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private TeleportingEnemy enemyPrefab;
    [SerializeField]
    private BaseEnemy[] enemies;
    [SerializeField]
    private Transform player;

    private bool gameStarted = false;

    
    private void Update()
    {
        if (gameStarted)
        {

            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] == null)
                {
                    // izbrisi go od nizata
                    // brisi go elementot so index i
                    // prodolzi so ciklusot
                    int indexOfEnemyToBeDestroyed = i;
                    BaseEnemy[] tmp = new BaseEnemy[enemies.Length - 1];
                    // copy the elemennts until the element you want to remove(i)
                    for(int j=0; j < indexOfEnemyToBeDestroyed; j++)
                    {
                        tmp[j] = enemies[j];
                    }

                    for (int j = indexOfEnemyToBeDestroyed; j < enemies.Length-1; j++)
                    {                       
                        tmp[j] = enemies[j+1];
                    }
                    enemies = tmp;
                    continue; //vs break;
                }

                enemies[i].Move(player.position);
            }


        }
    }

    public void PlayPressed()
    {
        gameStarted = true;
        if (gameObject.activeInHierarchy)
            StartCoroutine(DynamicSpawn());
    }

    private IEnumerator DynamicSpawn()
    {
        while (true)
        {
            Vector3 pos = new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f));
            BaseEnemy enemyInstance = Instantiate(enemyPrefab, pos, Quaternion.identity);
            enemyInstance.gameObject.SetActive(true);
            // enemyInstance treba da go stavime vo nizata

            BaseEnemy[] tmp = new BaseEnemy[enemies.Length + 1];
            // kopiranje na site elementi
            for (int i = 0; i < enemies.Length; i++)
            {
                tmp[i] = enemies[i];
            }
            tmp[enemies.Length] = enemyInstance; // go dodavame vo novata niza
            enemies = tmp; // promenlivata enemies ke pokazuva kon novata niza

            yield return new WaitForSeconds(.5f);

        }
    }
}
