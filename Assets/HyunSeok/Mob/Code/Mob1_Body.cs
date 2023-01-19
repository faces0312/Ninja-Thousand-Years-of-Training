using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1_Body : MonoBehaviour
{
    public Mob1 mob;

    public float lighting_hit_CT;
    public bool is_lighting_hit;

    private void OnEnable()
    {
        mob.rend.material.color = Color.white;
        is_lighting_hit = true;
        lighting_hit_CT = 0;
    }
    private void Update()
    {
        if (lighting_hit_CT > 0)
            lighting_hit_CT -= Time.deltaTime;
        else
        {
            is_lighting_hit = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Lighting_Line")
        {
            if(is_lighting_hit == true)
            {
                if(Data.Instance.gameData.lightning_lv ==1)
                {
                    mob.hp -= 1;
                    is_lighting_hit = false;
                    lighting_hit_CT = 0.5f;
                }
                else if (Data.Instance.gameData.lightning_lv == 2)
                {
                    mob.hp -= 2;
                    is_lighting_hit = false;
                    lighting_hit_CT = 0.5f;
                }
                else if (Data.Instance.gameData.lightning_lv == 3)
                {
                    mob.hp -= 3;
                    is_lighting_hit = false;
                    lighting_hit_CT = 0.5f;
                }
                else if (Data.Instance.gameData.lightning_lv == 4)
                {
                    mob.hp -= 5;
                    is_lighting_hit = false;
                    lighting_hit_CT = 0.5f;
                }
                else if (Data.Instance.gameData.lightning_lv == 5)
                {
                    mob.hp -= 7;
                    is_lighting_hit = false;
                    lighting_hit_CT = 0.5f;
                }
                else if (Data.Instance.gameData.lightning_lv == 6)
                {
                    mob.hp -= 10;
                    is_lighting_hit = false;
                    lighting_hit_CT = 0.5f;
                }

                if (mob.hp <= 0)
                {
                    //Manager.manager.objectManager.Normal_Atk_Letter_General(mob.gameObject.transform.position);
                    mob.die.SetBool("Is_Die", true);
                    gameObject.SetActive(false);
                    return;
                }
                StartCoroutine(AttackHit());
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Normal_Atk")
        {
            if(Data.Instance.gameData.normal_atk_lv == 1)
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

        if (collision.tag == "Lighting")
        {
            if (Data.Instance.gameData.lightning_lv == 6)
                mob.hp -= 25;
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
    }

    IEnumerator AttackHit()
    {
        mob.rend.material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        mob.rend.material.color = Color.white;
    }
}
