using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingEnemy : BaseEnemy
{
    [SerializeField]
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
        // dokolku renderer e vklucen, iskluci go | isklucen -> vkluci go
        //rend.enabled = false;

        //if (rend.enabled == false)//= - operator za dodeluvanje vrednost | == e operator za ednakvost
        //{
        //    rend.enabled = true;
        //}
        //else// koga e vklucen
        //{
        //    rend.enabled = false;
        //}
        //if (meshRenderer.enabled)
        //{
        //    meshRenderer.enabled = false;
        //}
        //else
        //{
        //    meshRenderer.enabled = true;
        //}
        //meshRenderer.enabled = meshRenderer.enabled ? false : true;
        meshRenderer.enabled = !meshRenderer.enabled;
    }
}
