using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Fire : MonoBehaviour
{
    public Player_Body player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBody")
        {
            player.in_Normal = false;
            player.in_Fire = true;
            player.in_Wood = false;
            player.in_Mecha = false;
        }
    }
}
