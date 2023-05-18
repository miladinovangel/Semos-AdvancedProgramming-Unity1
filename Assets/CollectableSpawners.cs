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

    private void Start()
    {
        StartCoroutine(CreateCollectables());
    }

    private IEnumerator CreateCollectables()
    {
        while (true)
        {
            float randomNumber = Random.Range(initialSpawnTimer1, initialSpawnTimer2); // generate random number
            yield return new WaitForSeconds(randomNumber); // wait the amount of the random number
            GameObject collectableInstantiate = Instantiate(collectablePrefab, transform.position, Quaternion.identity);// create collectable prefab and save it in a variable
            yield return new WaitForSeconds(5f); // wait 5 seconds
            if (collectableInstantiate != null) // null check - check if the object is destroyed
            {
                Destroy(collectableInstantiate); // destroy the object that you created
            }
        }
        
    }
}
