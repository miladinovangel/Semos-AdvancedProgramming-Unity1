using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
    //[SerializeField]
    //private TeleportingEnemy ;
    [SerializeField]
    private Transform player;
    private bool gameStarted = false;
    private List<BaseEnemy> enemies = new List<BaseEnemy>();
    [SerializeField]
    private List<BaseEnemy> enemyPrefabs;

    private void Update()
    {
        if (gameStarted)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i] == null)
                {
                    enemies.RemoveAt(i);

                    continue;
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
            Vector3 pos = new Vector3(Random.Range(-5f, 5f), 1f, Random.Range(-5f, 5f));

            int randomIndex = Random.Range(0, enemyPrefabs.Count);// generate random index
            BaseEnemy randomEnemy = enemyPrefabs[randomIndex]; // select random enemy
            BaseEnemy enemyInstance = Instantiate(randomEnemy, pos, Quaternion.identity);// create random enemy
            enemyInstance.gameObject.SetActive(true);
            enemies.Add(enemyInstance);

            yield return new WaitForSeconds(3f);
        }
    }
}


// a. koga enemy ke se sudri so player, treba da se unisti player-ot i da se prikaze game over text
// b. player-ot da ima 10 health, treba enemy objekt da go dopre player-ot 10 pati za da se unisti