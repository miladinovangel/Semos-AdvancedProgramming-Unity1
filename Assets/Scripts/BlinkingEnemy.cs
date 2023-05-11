using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingEnemy : BaseEnemy
{
    [SerializeField] // atribut od unity
    private MeshRenderer meshRenderer;
    // kako da go napravime da trepka

    private void Start()
    {
        // so pomos na korutina povikuvaj ja funkcijata Blink
        // InvokeRepeating("Blink", 1, 1);

        //TestCoroutine(); // vaka se povikuva funckija
        StartCoroutine(TestCoroutine()); // vaka se povikuva korutina
    }

    public override void Move(Vector3 targetPosition)
    {
        base.Move(targetPosition);

        // dopolnitelno ovde proverete dali playerot e blisku do enemyto i vklucete go
    }

    private IEnumerator TestCoroutine()
    {
        while (true)
        {
            //if (meshRenderer.enabled)
            //{
            //    yield return new WaitForSeconds(Random.Range(3f, 7f)); // pocekaj 5 sekundi
            //}
            //else
            //{
            //    yield return new WaitForSeconds(Random.Range(1f, 2f)); // pocekaj 5 sekundi
            //}
            //Blink();
            yield return new WaitForSeconds(Random.Range(3f, 7f));
            Blink();
            yield return new WaitForSeconds(Random.Range(1f, 2f));
            Blink();
        }
        

        // zadaca 1. namesto 5 sekundi, cekaj random vreme od 3 do 7
    }

    [ContextMenu("Blink")]
    private void Blink()
    {
        meshRenderer.enabled = !meshRenderer.enabled;
    }
}
