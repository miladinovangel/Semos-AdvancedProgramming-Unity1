using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPosition;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletInstance = Instantiate(bulletPrefab);
            bulletInstance.transform.position = bulletSpawnPosition.position;
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SpeedPowerupCollectable")
        {
            Destroy(other.gameObject);
            speed *= 1.2f;
            Invoke("ResetSpeed", 3f);
        }
    }

    private void ResetSpeed()
    {
        speed /= 1.2f;
    }
}

// Zadaca 3
// SpeedPowerupCollectable ne treba da go ima na pocetokot na scenata
// treba da napravite da se pojavuva na sekoj random sekundi od 10 do 20
// da izceznuva posle 5 sekundi

//1. so couroutine
//2. Instantiate - dynamic kreiranje na objekt
//3. prefab