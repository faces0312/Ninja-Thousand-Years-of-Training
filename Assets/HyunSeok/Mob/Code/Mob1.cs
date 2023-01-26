using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : MonoBehaviour
{
    public Animator die;
    public Mob1_Body mob1_Body;

    public SpriteRenderer rend;
    Vector3 start;
    Vector3 end;
    Vector3 fin;

    bool target_on;

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
        target_on = false;
        mob1_Body.gameObject.SetActive(true);
    }

    private void Update()
    {
        if(target_on == false)
        {
            transform.Translate(Vector3.right * 0.1f * Time.deltaTime);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && hp > 0)
        {
            target_on = true;
            start = this.transform.position;
            end = collision.transform.position;
            fin = end - start;

            if (fin.x > 0)
                rend.flipX = true;
            else
                rend.flipX = false;

            transform.position = Vector3.MoveTowards(start, end, speed * Time.deltaTime);
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}