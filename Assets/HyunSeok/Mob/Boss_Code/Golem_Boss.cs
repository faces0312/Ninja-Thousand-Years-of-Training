using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Boss : MonoBehaviour
{
    public Animator die;
    public Golem_Boss_Body golem_Boss_Body;

    /*public Boss_ShotGun shotGun;
    public Boss_ShotGun shotGun2;
    public Boss_ShotGun shotGun3;
    public Boss_Laser laser;
    public Boss_GunGroup gunGroup;*/

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
        hp = Data.Instance.gameData.bat_boss_hp;
        speed = 0.8f;
        target_on = true;
        golem_Boss_Body.gameObject.SetActive(true);
        /*shotGun.gameObject.SetActive(false);
        shotGun2.gameObject.SetActive(false);
        shotGun3.gameObject.SetActive(false);
        laser.gameObject.SetActive(false);
        gunGroup.gameObject.SetActive(false);*/
        //StartCoroutine(nameof(FindPlayer));

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
        StartCoroutine(nameof(FindPlayer));
    }*/

    private void FixedUpdate()
    {
        fin = target.transform.position - start;
        if (fin.x > 0)
            rend.flipX = true;
        else
            rend.flipX = false;
        /*if (target_on == true)
        {
            start = this.transform.position;
            transform.position = Vector3.MoveTowards(start, target.transform.position, speed * Time.deltaTime);
        }*/
        start = this.transform.position;
        transform.position = Vector3.MoveTowards(start, target.transform.position, speed * Time.deltaTime);
    }

    public void Die()
    {
        //StopCoroutine(nameof(FindPlayer));
        golem_Boss_Body.StopAllCoroutines();
        /*shotGun.gameObject.SetActive(false);
        shotGun2.gameObject.SetActive(false);
        shotGun3.gameObject.SetActive(false);
        laser.gameObject.SetActive(false);
        gunGroup.gameObject.SetActive(false);*/
        Manager.manager.objectManager.is_mob = true;
        Manager.manager.objectManager.is_bigwave = true;
        Manager.manager.objectManager.is_boss = true;
        Manager.manager.objectManager.bat_Macha_Wall.gameObject.SetActive(false);
        Manager.manager.objectManager.player_wall.gameObject.SetActive(false);
        Manager.manager.objectManager.boss_Tmp_CT = Manager.manager.objectManager.boss_CT;
        Data.Instance.gameData.bat_boss_hp += 1000;
        gameObject.SetActive(false);
    }
}
