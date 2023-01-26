using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Body : MonoBehaviour
{
    public Player player;
    public bool is_invin;//무적시간


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Mob")
        {
            if(is_invin == false)
            {
                StartCoroutine(Damage());
            }
        }
    }

    IEnumerator Damage()
    {
        player.hp -= 1;
        is_invin = true; 
        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }
}
