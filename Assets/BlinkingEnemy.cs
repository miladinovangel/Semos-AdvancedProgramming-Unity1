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
        InvokeRepeating("Blink", 1, 1);
    }

    [ContextMenu("Blink")]
    private void Blink()
    {
        meshRenderer.enabled = !meshRenderer.enabled;
    }
}
