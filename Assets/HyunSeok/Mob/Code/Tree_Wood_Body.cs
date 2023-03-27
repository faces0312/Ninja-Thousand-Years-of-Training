using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Wood_Body : MonoBehaviour
{
    public Tree_Wood mob;

    private bool is_windwall;
    private void OnEnable()
    {
        mob.rend.material.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Max_Dmg")
        {
            mob.hp -= 10000000000;

            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }
        if (collision.tag == "Normal_Atk")
        {
            if (Data.Instance.gameData.normal_atk_lv == 1)
                mob.hp -= (1 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.normal_atk_lv == 2)
                mob.hp -= (2 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.normal_atk_lv == 3)
                mob.hp -= (3 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.normal_atk_lv == 4)
                mob.hp -= (4 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.normal_atk_lv == 5)
                mob.hp -= (5 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.normal_atk_lv == 6)
                mob.hp -= (5 + Data.Instance.gameData.player_normal);

            collision.gameObject.SetActive(false);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Shadow_Atk")
        {
            if (Data.Instance.gameData.shadow_partner_lv == 1)
                mob.hp -= (1 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.shadow_partner_lv == 2)
                mob.hp -= (2 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.shadow_partner_lv == 3)
                mob.hp -= (2 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.shadow_partner_lv == 4)  //분신이 두명이래
                mob.hp -= (2 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.shadow_partner_lv == 5)
                mob.hp -= (3 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.shadow_partner_lv == 6)
                mob.hp -= (4 + Data.Instance.gameData.player_normal);

            collision.gameObject.SetActive(false);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Boomerang")
        {
            if (Data.Instance.gameData.boomerang_lv == 1)
                mob.hp -= (5 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.boomerang_lv == 2)
                mob.hp -= (7 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.boomerang_lv == 3)
                mob.hp -= (10 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.boomerang_lv == 4)
                mob.hp -= (15 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.boomerang_lv == 5)
                mob.hp -= (20 + Data.Instance.gameData.player_normal);
            else if (Data.Instance.gameData.boomerang_lv == 6)
                mob.hp -= (25 + Data.Instance.gameData.player_normal);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Fire")
        {
            if (Data.Instance.gameData.fire_lv == 1)
                mob.hp -= ((5 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_lv == 2)
                mob.hp -= ((7 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_lv == 3)
                mob.hp -= ((10 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_lv == 4)
                mob.hp -= ((20 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_lv == 5)
                mob.hp -= ((30 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_lv == 6)
                mob.hp -= ((40 + Data.Instance.gameData.player_fire) * 1.3f);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Talisman")
        {
            if (Data.Instance.gameData.talisman_lv == 1)
                mob.hp -= ((5 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.talisman_lv == 2)
                mob.hp -= ((7 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.talisman_lv == 3)
                mob.hp -= ((10 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.talisman_lv == 4)
                mob.hp -= ((15 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.talisman_lv == 5)
                mob.hp -= ((20 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.talisman_lv == 6)
                mob.hp -= ((25 + Data.Instance.gameData.player_fire) * 1.3f);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "FireColumn")
        {
            if (Data.Instance.gameData.fire_column_lv == 1)
                mob.hp -= ((10 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_column_lv == 2)
                mob.hp -= ((15 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_column_lv == 3)
                mob.hp -= ((20 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_column_lv == 4)
                mob.hp -= ((25 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_column_lv == 5)
                mob.hp -= ((30 + Data.Instance.gameData.player_fire) * 1.3f);
            else if (Data.Instance.gameData.fire_column_lv == 6)
                mob.hp -= ((50 + Data.Instance.gameData.player_fire) * 1.3f);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Tornado")
        {
            if (Data.Instance.gameData.tornado_lv == 1)
                mob.hp -= ((3 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.tornado_lv == 2)
                mob.hp -= ((5 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.tornado_lv == 3)
                mob.hp -= ((7 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.tornado_lv == 4)
                mob.hp -= ((10 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.tornado_lv == 5)
                mob.hp -= ((15 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.tornado_lv == 6)
                mob.hp -= ((20 + Data.Instance.gameData.player_mecha));
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "VoltTackle")
        {
            if (Data.Instance.gameData.voltTackle_lv == 1)
                mob.hp -= ((3 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.voltTackle_lv == 2)
                mob.hp -= ((5 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.voltTackle_lv == 3)
                mob.hp -= ((7 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.voltTackle_lv == 4)
                mob.hp -= ((10 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.voltTackle_lv == 5)
                mob.hp -= ((12 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.voltTackle_lv == 6)
                mob.hp -= ((15 + Data.Instance.gameData.player_mecha));
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Electric")
        {
            if (Data.Instance.gameData.electricity_lv == 1)
                mob.hp -= ((7 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 2)
                mob.hp -= ((10 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 3)
                mob.hp -= ((15 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 4)
                mob.hp -= ((20 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 5)
                mob.hp -= ((25 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 6)
                mob.hp -= ((30 + Data.Instance.gameData.player_mecha));
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Electric_Area")
        {
            if (Data.Instance.gameData.electricity_lv == 1)
                mob.hp -= ((3 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 2)
                mob.hp -= ((3 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 3)
                mob.hp -= ((5 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 4)
                mob.hp -= ((5 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 5)
                mob.hp -= ((7 + Data.Instance.gameData.player_mecha));
            else if (Data.Instance.gameData.electricity_lv == 6)
                mob.hp -= ((10 + Data.Instance.gameData.player_mecha));
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Wind")
        {
            if (Data.Instance.gameData.wind_lv == 1)
                mob.hp -= (7 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.wind_lv == 2)
                mob.hp -= (10 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.wind_lv == 3)
                mob.hp -= (10 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.wind_lv == 4)
                mob.hp -= (15 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.wind_lv == 5)
                mob.hp -= (20 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.wind_lv == 6)
                mob.hp -= (25 + Data.Instance.gameData.player_wood);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "WindWall")    //건들
        {
            StartCoroutine(Stun());
            if (Data.Instance.gameData.windwall_lv == 1)
                mob.hp -= (2 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.windwall_lv == 2)
                mob.hp -= (4 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.windwall_lv == 3)
                mob.hp -= (6 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.windwall_lv == 4)
                mob.hp -= (8 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.windwall_lv == 5)
                mob.hp -= (10 + Data.Instance.gameData.player_wood);
            else if (Data.Instance.gameData.windwall_lv == 6)
                mob.hp -= (12 + Data.Instance.gameData.player_wood);
            if (mob.hp <= 0)
            {
                mob.speed = 0;
                mob.die.SetBool("Is_Die", true);
                Drop_Letter();
                mob.StopAllCoroutines();
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());

        }
    }

    IEnumerator Stun()
    {
        mob.speed = 0;
        yield return new WaitForSeconds(1f);
        mob.speed = 1;
    }

    IEnumerator AttackHit()
    {
        mob.rend.material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        mob.rend.material.color = Color.white;
    }

    public void Drop_Letter()
    {
        int drop;
        drop = Random.Range(1, 101);

        if (drop <= Data.Instance.gameData.drop_percent)
        {
            if (Data.Instance.gameData.drop_percent > 1)
                Data.Instance.gameData.drop_percent--;
            Manager.manager.objectManager.Wood_Letter_General(mob.gameObject.transform.position);
        }
        else
            return;
    }
}
