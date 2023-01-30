using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Wood : MonoBehaviour
{
    public ObjectManager manager;
    bool is_first;
    public Player_Body player;

    private void Start()
    {
        is_first = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBody")
        {
            if (is_first == true)
            {
                for (int i = 0; i < 15; i++)
                    manager.Mob_General();
                is_first = false;
            }
            player.in_Normal = false;
            player.in_Fire = false;
            player.in_Wood = true;
            player.in_Mecha = false;
        }
    }
}
