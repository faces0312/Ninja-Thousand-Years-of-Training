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

    private void OnEnable()
    {
        player.rend.material.color = Color.white;
    }

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
                StartCoroutine(Sick());
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

    IEnumerator Sick()
    {  // 데미지랑 합치자
        int count = 0;
        is_invin = true;
        while (count < 2)
        {

            if (count % 2 == 0)
                player.rend.material.color = new Color32(255, 255, 255, 40);
            else
                player.rend.material.color = new Color32(255, 255, 255, 250);

            yield return new WaitForSeconds(0.2f);

            count++;


        }
        player.rend.material.color = Color.white;

        is_invin = false;
        yield return null;
    }
}
