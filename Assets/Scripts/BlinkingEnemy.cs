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

    private IEnumerator TestCoroutine()
    {
        //
        //Blink();
        yield return new WaitForSeconds(5f); // pocekaj 5 sekundi
        Blink();
    }

    [ContextMenu("Blink")]
    private void Blink()
    {
        meshRenderer.enabled = !meshRenderer.enabled;
    }
}
