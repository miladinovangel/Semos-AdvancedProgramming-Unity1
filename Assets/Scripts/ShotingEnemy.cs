using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotingEnemy : BaseEnemy
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPosition;
    private void Start()
    {
        StartCoroutine(CreateBullets());
    }

    private IEnumerator CreateBullets()
    {
        yield return new WaitForSeconds(0.5f);
        while (true)
        {           
            GameObject bulletInstance = Instantiate(bulletPrefab);
            bulletInstance.transform.position = bulletSpawnPosition.position;
            yield return new WaitForSeconds(3f);
        }
    }
}
