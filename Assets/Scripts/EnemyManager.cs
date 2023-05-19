using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato
{

}

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private TeleportingEnemy enemyPrefab;
    [SerializeField]
    private Transform player;
    private bool gameStarted = false;
    //private CustomArray array = new CustomArray();

    [SerializeField]
    private int[] TEST1;
    private BaseEnemy[] ttttt;


    private List<BaseEnemy> enemies = new List<BaseEnemy>();
    private List<Potato> potatos = new List<Potato>();

    //private void Start()
    //{
    //    //enemies.Add()
    //    enemies.RemoveAt(3);

    //    if (TEST1 == null)
    //    {
    //        Debug.Log("TEST is NULL");
    //    }
    //    // experiment 
    //    CustomArrayString playerNames = new CustomArrayString();
    //    playerNames.AddElement("Angel");
    //    playerNames.AddElement("Martin");
    //    playerNames.AddElement("Viktor");
    //    string randomName = playerNames.array[Random.Range(0, 3)];
    //    Debug.Log(randomName);


    //    CustomGenericArray<string> genericStringArray = new CustomGenericArray<string>();
    //    genericStringArray.AddElement("Angel");
    //    genericStringArray.AddElement("Martin");
    //    genericStringArray.AddElement("Viktor");
    //    randomName = genericStringArray.array[Random.Range(0, 3)];
    //}

    private void Start()
    {
        List<int> integers = new List<int>();
        integers.Add(2);
        integers.Add(3);
        integers.Add(1);
        integers.Add(8);
        integers.Add(-1);

        integers.Remove(1);
        integers.RemoveAt(0);

        List<string> strings = new List<string>();
        strings.Add("qwerty");
        strings.Add("testtest");

        strings.RemoveAt(1);
    }

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
