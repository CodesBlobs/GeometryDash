using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    Player player;
    private void Awake()
    {
        player = GetComponentInParent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.grounded = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        player.grounded = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.grounded = false;
    }
}
