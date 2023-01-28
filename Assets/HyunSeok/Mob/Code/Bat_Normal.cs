using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Normal : MonoBehaviour
{
    public Animator die;
    public Bat_Normal_Body bat_Normal_Body;
    public Mob_Atk atk;

    public SpriteRenderer rend;
    Vector3 start;
    Vector3 end;
    Vector3 fin;

    public bool target_on;

    public int hp;
    public int speed;
    // Update is called once per frame

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        rend = GetComponent<SpriteRenderer>();
        hp = 10;
        speed = 1;
        target_on = true;
        bat_Normal_Body.gameObject.SetActive(true);
        atk.gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && hp > 0)
        {
            start = this.transform.position;
            end = collision.transform.position;
            if (target_on == true)
            {
                transform.position = Vector3.MoveTowards(start, end, speed * Time.deltaTime);
            }
            fin = end - start;
            if (fin.x > 0)
                rend.flipX = true;
            else
                rend.flipX = false;
        }
    }

    public void Die()
    {
        atk.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
