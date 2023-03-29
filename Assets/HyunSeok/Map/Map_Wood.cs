using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Wood : MonoBehaviour
{
    public Player_Body player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBody")
        {
            if (Manager.manager.is_wood_name == false)
            {
                Manager.manager.is_wood_name = true;

                Manager.manager.Go_Wood_Name();
            }
            player.in_Normal = false;
            player.in_Fire = false;
            player.in_Wood = true;
            player.in_Mecha = false;
        }
    }
}
