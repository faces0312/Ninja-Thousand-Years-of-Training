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
        if (collision.tag == "Mob1")
        {
            if(is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Mob1());
            }
        }
        else if (collision.tag == "Bat_Body")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Bat_Body());
            }
        }
        else if (collision.tag == "Bat_Atk")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Bat_Atk());
                collision.gameObject.SetActive(false);
            }
        }
        else if (collision.tag == "GateKeeper")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_GateKeeper());
            }
        }
        else if (collision.tag == "Bat_Boss")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Bat_Boss());
            }
        }
        else if (collision.tag == "Bat_Boss_Attack")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Bat_Boss_Atk());
                collision.gameObject.SetActive(false);
            }
        }
        else if (collision.tag == "Bat_Boss_Laser")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Bat_Boss_Laser());
            }
        }
        else if (collision.tag == "Golem")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Golem());
            }
        }
        else if (collision.tag == "Golem_Boss")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Golem_Boss());
            }
        }
        else if (collision.tag == "Golem_Boss_Lighting")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Golem_Boss_Lighting());
            }
        }
        else if (collision.tag == "Golem_Boss_Wire")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Golem_Boss_Wire());
            }
        }
        else if (collision.tag == "Golem_Boss_Laser")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Golem_Boss_Laser());
            }
        }
        else if (collision.tag == "Redspit_Boss")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Redspit_Boss());
            }
        }
        else if (collision.tag == "Redspit_Boss_Attack")
        {
            if (is_invin == false)
            {
                StartCoroutine(Sick());
                StartCoroutine(Damage_Redspit_Boss_Attack());
                collision.gameObject.SetActive(false);
            }
        }

    }

    IEnumerator Damage_Redspit_Boss()
    {
        player.hp -= Data.Instance.gameData.redspit_boss_body;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Redspit_Boss_Attack()
    {
        player.hp -= Data.Instance.gameData.redspit_boss_atk;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Mob1()
    {
        player.hp -= Data.Instance.gameData.mob1_dmg;
        is_invin = true; 

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Bat_Body()
    {
        player.hp -= Data.Instance.gameData.bat_body_dmg;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Bat_Atk()
    {
        player.hp -= Data.Instance.gameData.bat_atk_dmg;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_GateKeeper()
    {
        player.hp -= Data.Instance.gameData.gatekeeper_dmg;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Bat_Boss()
    {
        player.hp -= Data.Instance.gameData.bat_boss_body;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Bat_Boss_Atk()
    {
        player.hp -= Data.Instance.gameData.bat_boss_atk;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Bat_Boss_Laser()
    {
        player.hp -= Data.Instance.gameData.bat_boss_laser;
        is_invin = true;

        yield return new WaitForSeconds(0.8f);
        is_invin = false;
    }

    IEnumerator Damage_Golem()
    {
        player.hp -= Data.Instance.gameData.golem_dmg;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Golem_Boss()
    {
        player.hp -= Data.Instance.gameData.golem_boss_body;
        is_invin = true;

        yield return new WaitForSeconds(0.1f);
        is_invin = false;
    }

    IEnumerator Damage_Golem_Boss_Lighting()
    {
        player.hp -= Data.Instance.gameData.golem_boss_lighting;
        is_invin = true;

        yield return new WaitForSeconds(0.5f);
        is_invin = false;
    }

    IEnumerator Damage_Golem_Boss_Wire()
    {
        player.hp -= Data.Instance.gameData.golem_boss_wire;
        is_invin = true;

        yield return new WaitForSeconds(0.5f);
        is_invin = false;
    }

    IEnumerator Damage_Golem_Boss_Laser()
    {
        player.hp -= Data.Instance.gameData.golem_boss_laser;
        is_invin = true;

        yield return new WaitForSeconds(0.8f);
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
