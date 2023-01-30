using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Body : MonoBehaviour
{
    public Player player;
    public bool is_invin;//무적시간

    public bool in_Normal;//플레이어가 있는 지형(노말)
    public bool in_Fire;//플레이어가 있는 지형(화염)
    public bool in_Wood;//플레이어가 있는 지형(숲)
    public bool in_Mecha;//플레이어가 있는 지형(기계)

    private void Start()
    {
        in_Normal = true;
        in_Fire = false;
        in_Wood = false;
        in_Mecha = false;
    }
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
