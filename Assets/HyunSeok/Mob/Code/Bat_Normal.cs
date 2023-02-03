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
    Transform end;
    Vector3 fin;

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
        rend = GetComponent<SpriteRenderer>();
        hp = Data.Instance.gameData.bat_normal_hp;
        speed = 1.3f;
        target_on = true;
        bat_Normal_Body.gameObject.SetActive(true);
        atk.gameObject.SetActive(false);
        StartCoroutine(FindPlayer());
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
        if (target_on == true)
        {
            start = this.transform.position;
            transform.position = Vector3.MoveTowards(start, end.position, speed * Time.deltaTime);
        }
    }

    public void Die()
    {
        atk.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
