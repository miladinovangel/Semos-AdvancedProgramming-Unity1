using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private TeleportingEnemy enemyPrefab;
    [SerializeField]
    private Transform player;
    private bool gameStarted = false;
    private List<BaseEnemy> enemies = new List<BaseEnemy>();

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
            Vector3 pos = new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f));
            BaseEnemy enemyInstance = Instantiate(enemyPrefab, pos, Quaternion.identity);
            enemyInstance.gameObject.SetActive(true);
            enemies.Add(enemyInstance);

            yield return new WaitForSeconds(.5f);
        }
    }
}
