using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Wood : MonoBehaviour
{
    public Animator die;
    public Bat_Wood_Body bat_Wood_Body;
    public Mob_Atk atk;

    public SpriteRenderer rend;
    Vector3 start;
    Vector3 fin;

    public Rigidbody2D target;
    public bool target_on;

    public float hp;
    public float speed;
    // Update is called once per frame

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        target = Manager.manager.player.GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        hp = Data.Instance.gameData.bat_wood_hp;
        speed = 1.3f;
        target_on = true;
        bat_Wood_Body.gameObject.SetActive(true);
        atk.gameObject.SetActive(false);
        //StartCoroutine(FindPlayer());
    }

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && hp > 0)
        {
            end = collision.transform.position;
            fin = end - start;
            if (fin.x > 0)
                rend.flipX = true;
            else
                rend.flipX = false;
        }
    }*/

    /*public IEnumerator FindPlayer()
    {
        end = GameObject.FindObjectOfType<Player>().transform;
        yield return new WaitForSeconds(find_num);
        StartCoroutine(FindPlayer());
    }*/

    private void FixedUpdate()
    {
        fin = target.transform.position - start;
        if (fin.x > 0)
            rend.flipX = true;
        else
            rend.flipX = false;
        if (target_on == true)
        {
            start = this.transform.position;
            transform.position = Vector3.MoveTowards(start, target.transform.position, speed * Time.deltaTime);
        }
    }

    public void Die()
    {
        Data.Instance.gameData.mob_cnt--;
        //StopCoroutine(nameof(FindPlayer));
        bat_Wood_Body.StopAllCoroutines();
        atk.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
