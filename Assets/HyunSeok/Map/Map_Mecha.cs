using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Mecha : MonoBehaviour
{
    public Player_Body player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBody")
        {
            if(Manager.manager.is_mecha_name == false)
            {
                Manager.manager.is_mecha_name = true;

                Manager.manager.map_name.gameObject.SetActive(false);
                Manager.manager.fire_map_name.gameObject.SetActive(false);
                Manager.manager.fire_map_name_image.gameObject.SetActive(false);
                Manager.manager.fire_map_name_text.gameObject.SetActive(false);
                Manager.manager.wood_map_name.gameObject.SetActive(false);
                Manager.manager.wood_map_name_image.gameObject.SetActive(false);
                Manager.manager.wood_map_name_text.gameObject.SetActive(false);
                Manager.manager.map_name_left.gameObject.SetActive(false);
                Manager.manager.map_name_right.gameObject.SetActive(false);

                Manager.manager.Go_Mecha_Name();
            }
            player.in_Normal = false;
            player.in_Fire = false;
            player.in_Wood = false;
            player.in_Mecha = true;
        }
    }
}
