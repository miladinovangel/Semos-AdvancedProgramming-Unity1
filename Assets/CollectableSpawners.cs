using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawners : MonoBehaviour
{
    [SerializeField]
    private GameObject collectablePrefab;
    [SerializeField]
    private float initialSpawnTimer1;
    [SerializeField]
    private float initialSpawnTimer2;

    //private void Start()
    //{
    //    //StartCoroutine(CreateCollectables());
    //}

    public void GameStarted()
    {
        if (gameObject.activeInHierarchy)
            StartCoroutine(CreateCollectables());
    }

    private IEnumerator CreateCollectables()
    {
        while (true)
        {
            float randomNumber = Random.Range(initialSpawnTimer1, initialSpawnTimer2); // generate random number
            yield return new WaitForSeconds(randomNumber); // wait the amount of the random number
            //1. Vector3 position = new Vector3(Random.Range(-5f, 5f), 1.18f, Random.Range(-5f, 5f));
            //2.
            Vector3 position = collectablePrefab.transform.position;
            position.x = Random.Range(-5f, 5f);
            position.z = Random.Range(-5f, 5f);
            GameObject collectableInstantiate = Instantiate(collectablePrefab, position, Quaternion.identity);// create collectable prefab and save it in a variable
            yield return new WaitForSeconds(5f); // wait 5 seconds
            if (collectableInstantiate != null) // null check - check if the object is destroyed
            {
                Destroy(collectableInstantiate); // destroy the object that you created
            }
        }
        
    }
}
