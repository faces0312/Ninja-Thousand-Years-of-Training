using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit : MonoBehaviour
{
    public Animator die;
    public Redspit_Body redspit_Body;

    public SpriteRenderer rend;
    Vector2 start;
    Vector2 fin;

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
        //target_on = false;
        redspit_Body.gameObject.SetActive(true);
        //StartCoroutine(FindPlayer());
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

    /*public IEnumerator FindPlayer()
    {
        end = GameObject.FindObjectOfType<Player>().transform;
        yield return new WaitForSeconds(find_num);
        StartCoroutine(FindPlayer());
    }*/

    private void FixedUpdate()
    {
        fin = Data.Instance.gameData.player_Location - start;
        if (fin.x > 0)
            rend.flipX = true;
        else
            rend.flipX = false;
        start = this.transform.position;
        transform.position = Vector3.MoveTowards(start, Data.Instance.gameData.player_Location, speed * Time.deltaTime);

        //transform.position = Vector3.MoveTowards(start, Camera.main.transform.position, speed * Time.deltaTime);
    }

    public void Die()
    {
        //StopCoroutine(nameof(FindPlayer));
        redspit_Body.StopAllCoroutines();
        gameObject.SetActive(false);
    }
}