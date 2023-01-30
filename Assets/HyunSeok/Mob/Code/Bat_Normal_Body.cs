using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Normal_Body : MonoBehaviour
{
    public Bat_Normal mob;

    private void OnEnable()
    {
        mob.rend.material.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Normal_Atk")
        {
            if (Data.Instance.gameData.normal_atk_lv == 1)
                mob.hp -= 1;
            else if (Data.Instance.gameData.normal_atk_lv == 2)
                mob.hp -= 2;
            else if (Data.Instance.gameData.normal_atk_lv == 3)
                mob.hp -= 3;
            else if (Data.Instance.gameData.normal_atk_lv == 4)
                mob.hp -= 4;
            else if (Data.Instance.gameData.normal_atk_lv == 5)
                mob.hp -= 5;
            else if (Data.Instance.gameData.normal_atk_lv == 6)
                mob.hp -= 5;

            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                Manager.manager.objectManager.Normal_Atk_Letter_General(mob.gameObject.transform.position);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Shadow_Atk")
        {
            if (Data.Instance.gameData.shadow_partner_lv == 1)
                mob.hp -= 1;
            else if (Data.Instance.gameData.shadow_partner_lv == 2)
                mob.hp -= 2;
            else if (Data.Instance.gameData.shadow_partner_lv == 3)
                mob.hp -= 2;
            else if (Data.Instance.gameData.shadow_partner_lv == 4)
                mob.hp -= 3;
            else if (Data.Instance.gameData.shadow_partner_lv == 5)
                mob.hp -= 5;
            else if (Data.Instance.gameData.shadow_partner_lv == 6)
                mob.hp -= 5;

            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Fire")
        {
            if (Data.Instance.gameData.fire_lv == 1)
                mob.hp -= 5;
            else if (Data.Instance.gameData.fire_lv == 2)
                mob.hp -= 7;
            else if (Data.Instance.gameData.fire_lv == 3)
                mob.hp -= 10;
            else if (Data.Instance.gameData.fire_lv == 4)
                mob.hp -= 10;
            else if (Data.Instance.gameData.fire_lv == 5)
                mob.hp -= 15;
            else if (Data.Instance.gameData.fire_lv == 6)
                mob.hp -= 30;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Wind")
        {
            if (Data.Instance.gameData.wind_lv == 1)
                mob.hp -= 10;
            else if (Data.Instance.gameData.wind_lv == 2)
                mob.hp -= 10;
            else if (Data.Instance.gameData.wind_lv == 3)
                mob.hp -= 15;
            else if (Data.Instance.gameData.wind_lv == 4)
                mob.hp -= 15;
            else if (Data.Instance.gameData.wind_lv == 5)
                mob.hp -= 20;
            else if (Data.Instance.gameData.wind_lv == 6)
                mob.hp -= 20;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "FireColumn")
        {
            if (Data.Instance.gameData.fire_column_lv == 1)
                mob.hp -= 10;
            else if (Data.Instance.gameData.fire_column_lv == 2)
                mob.hp -= 10;
            else if (Data.Instance.gameData.fire_column_lv == 3)
                mob.hp -= 15;
            else if (Data.Instance.gameData.fire_column_lv == 4)
                mob.hp -= 15;
            else if (Data.Instance.gameData.fire_column_lv == 5)
                mob.hp -= 20;
            else if (Data.Instance.gameData.fire_column_lv == 6)
                mob.hp -= 20;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "VoltTackle")
        {
            if (Data.Instance.gameData.voltTackle_lv == 1)
                mob.hp -= 10;
            else if (Data.Instance.gameData.voltTackle_lv == 2)
                mob.hp -= 10;
            else if (Data.Instance.gameData.voltTackle_lv == 3)
                mob.hp -= 15;
            else if (Data.Instance.gameData.voltTackle_lv == 4)
                mob.hp -= 15;
            else if (Data.Instance.gameData.voltTackle_lv == 5)
                mob.hp -= 20;
            else if (Data.Instance.gameData.voltTackle_lv == 6)
                mob.hp -= 20;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Tornado")
        {
            if (Data.Instance.gameData.tornado_lv == 1)
                mob.hp -= 10;
            else if (Data.Instance.gameData.tornado_lv == 2)
                mob.hp -= 10;
            else if (Data.Instance.gameData.tornado_lv == 3)
                mob.hp -= 15;
            else if (Data.Instance.gameData.tornado_lv == 4)
                mob.hp -= 15;
            else if (Data.Instance.gameData.tornado_lv == 5)
                mob.hp -= 20;
            else if (Data.Instance.gameData.tornado_lv == 6)
                mob.hp -= 20;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Boomerang")
        {
            if (Data.Instance.gameData.boomerang_lv == 1)
                mob.hp -= 10;
            else if (Data.Instance.gameData.boomerang_lv == 2)
                mob.hp -= 10;
            else if (Data.Instance.gameData.boomerang_lv == 3)
                mob.hp -= 15;
            else if (Data.Instance.gameData.boomerang_lv == 4)
                mob.hp -= 15;
            else if (Data.Instance.gameData.boomerang_lv == 5)
                mob.hp -= 20;
            else if (Data.Instance.gameData.boomerang_lv == 6)
                mob.hp -= 20;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }

        if (collision.tag == "Electricity")
        {
            if (Data.Instance.gameData.electricity_lv == 1)
                mob.hp -= 10;
            else if (Data.Instance.gameData.electricity_lv == 2)
                mob.hp -= 10;
            else if (Data.Instance.gameData.electricity_lv == 3)
                mob.hp -= 15;
            else if (Data.Instance.gameData.electricity_lv == 4)
                mob.hp -= 15;
            else if (Data.Instance.gameData.electricity_lv == 5)
                mob.hp -= 20;
            else if (Data.Instance.gameData.electricity_lv == 6)
                mob.hp -= 20;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }
        if (collision.tag == "Electric")
        {
            if (Data.Instance.gameData.electricity_lv == 1)
                mob.hp -= 10;
            else if (Data.Instance.gameData.electricity_lv == 2)
                mob.hp -= 10;
            else if (Data.Instance.gameData.electricity_lv == 3)
                mob.hp -= 15;
            else if (Data.Instance.gameData.electricity_lv == 4)
                mob.hp -= 15;
            else if (Data.Instance.gameData.electricity_lv == 5)
                mob.hp -= 20;
            else if (Data.Instance.gameData.electricity_lv == 6)
                mob.hp -= 20;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
                gameObject.SetActive(false);
                return;
            }
            StartCoroutine(AttackHit());
        }
        if (collision.tag == "WindWall")    //°Çµé
        {
            StartCoroutine(Stun());
            if (Data.Instance.gameData.windwall_lv == 1)
                mob.hp -= 1;
            else if (Data.Instance.gameData.windwall_lv == 2)
                mob.hp -= 2;
            else if (Data.Instance.gameData.windwall_lv == 3)
                mob.hp -= 3;
            else if (Data.Instance.gameData.windwall_lv == 4)
                mob.hp -= 4;
            else if (Data.Instance.gameData.windwall_lv == 5)
                mob.hp -= 5;
            else if (Data.Instance.gameData.windwall_lv == 6)
                mob.hp -= 6;
            if (mob.hp <= 0)
            {
                mob.die.SetBool("Is_Die", true);
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
}
