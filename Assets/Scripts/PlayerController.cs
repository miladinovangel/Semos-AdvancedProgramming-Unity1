using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPosition;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private TextMeshProUGUI playerHealthText;
    [SerializeField]private int playerHealth;

    private void Start()
    {
        UpdatePlayerHealthUI();
    }
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
        if (other.gameObject.tag == "Enemy")
        {
            playerHealth--;
            UpdatePlayerHealthUI();
            if (playerHealth <= 0)
            {
                GetCameraOutOfPlayer();

                // turn on game over text
                gameOverText.SetActive(true);

                // destory player
                Destroy(gameObject);
            }
        }
    }

    private void UpdatePlayerHealthUI()
    {
        playerHealthText.text = $"Health: {playerHealth}";
    }

    private void GetCameraOutOfPlayer()
    {
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.transform.SetParent(null);
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


// Zadaca 4
// napiste logika sto ke kreira enemy 1 objekti na random pozicija na sekoj 7-10 sec
// koga ke klikneme play, togas treba da ni se pojavuvaat enemies