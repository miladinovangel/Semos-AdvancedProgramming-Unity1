using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingEnemy : BaseEnemy
{
    [SerializeField]
    private float teleportRange;

    private void Start()
    {
        //jumpForce *= 0.5f;
        InvokeRepeating("Teleport", 4, 5); //izvrsuvaj ja funkcijata Teleport na sekoi 5 sekundi posle 4 sek(prviot pat).
    }

    [ContextMenu("Teleport")] // magija - dodava kontekst meni koga ke stisneme na 3te tocki na skriptata so ime Teleport, so klik na toa kopce se povikuva funkcijata
    private void Teleport()
    {
        Vector3 pos = transform.position;
        pos.z += GetRandomRange();
        pos.x += GetRandomRange();
        transform.position = pos;
    }

    private float GetRandomRange()
    {
        return Random.Range(-teleportRange, teleportRange);
    }

    public override void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce* 0.5f);
    }
}
