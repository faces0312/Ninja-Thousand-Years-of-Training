using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : MonoBehaviour
{
    public Animator die;
    public Mob1_Body mob1_Body;

    public SpriteRenderer rend;
    Vector3 start;
    Transform end;
    Vector3 fin;

    bool target_on;

    public float hp;
    public int speed;
    // Update is called once per frame

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        rend = GetComponent<SpriteRenderer>();
        hp = Data.Instance.gameData.mob1_hp;
        speed = 1;
        target_on = false;
        mob1_Body.gameObject.SetActive(true);
        StartCoroutine(FindPlayer());
    }

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && hp > 0)
        {
            target_on = true;
            end = collision.transform.position;

            fin = end - start;
            if (fin.x > 0)
                rend.flipX = true;
            else
                rend.flipX = false;
        }
    }*/

    public IEnumerator FindPlayer()
    {
        end = GameObject.FindObjectOfType<Player>().transform;
        yield return new WaitForSeconds(1f);
        StartCoroutine(FindPlayer());
    }

    private void FixedUpdate()
    {
        fin = end.position - start;
        if (fin.x > 0)
            rend.flipX = true;
        else
            rend.flipX = false;
        start = this.transform.position;
        transform.position = Vector3.MoveTowards(start, end.position, speed * Time.deltaTime);
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}