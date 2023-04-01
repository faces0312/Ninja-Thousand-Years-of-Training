using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Boss_Area : MonoBehaviour
{
    public Bat_Boss mob;

    /*public Boss_ShotGun shotGun;
    public Boss_ShotGun shotGun2;
    public Boss_ShotGun shotGun3;
    public Boss_Laser laser;
    public Boss_GunGroup gunGroup;*/

    public Boss_Laser laser;
    public int laser_ran;

    int atk_ran;
    
    public float atk_CT;
    private float atk_Tmp_CT;

    //bool is_area;
    private void OnEnable()
    {
        atk_CT = 4.5f;
        atk_Tmp_CT = 1f;
    }
    private void Update()
    {
        /*if (is_area == true)
        {
            mob.target_on = false;
            if (atk_Tmp_CT > 0)
                atk_Tmp_CT -= Time.deltaTime;
            else
            {
                atk.gameObject.transform.position = mob.gameObject.transform.position;
                Vector3 start = atk.transform.position;
                Vector3 end = mob.target.transform.position;
                Vector3 fin = end - start;
                atk.transform.rotation = Quaternion.Euler(atk.transform.rotation.x, atk.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
                atk.gameObject.SetActive(true);
                atk_Tmp_CT = atk_CT;
            }
        }*/
        if ((mob.target.transform.position - gameObject.transform.position).sqrMagnitude < 18f)
        {
            mob.target_on = false;
            if (atk_Tmp_CT > 0)
                atk_Tmp_CT -= Time.deltaTime;
            else
            {
                atk_ran = Random.Range(0, 3);
                if (atk_ran == 0)
                    Laser();
                else if (atk_ran == 1)
                    Manager.manager.objectManager.Bat_Boss_ShotGun_General(mob.gameObject.transform.position);
                else if (atk_ran == 2)
                    Manager.manager.objectManager.Bat_Boss_GunGroup_General(mob.gameObject.transform.position);

                atk_Tmp_CT = atk_CT;
            }
        }
        else
            mob.target_on = true;
    }

    void Laser()
    {
        Manager.manager.sound.BossLaser();
        //¼¦°Ç ÄÚµå
        laser.gameObject.transform.position = mob.gameObject.transform.position;

        Vector3 start = laser.transform.position;
        Vector3 end = mob.target.transform.position;
        Vector3 fin = end - start;

        laser_ran = Random.Range(0, 2);
        if(laser_ran == 0)
            laser.transform.rotation = Quaternion.Euler(laser.transform.rotation.x, laser.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 120);
        else
            laser.transform.rotation = Quaternion.Euler(laser.transform.rotation.x, laser.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 210);

        laser.gameObject.SetActive(true);
    }


    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            is_area = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            is_area = false;
            mob.target_on = true;
        }
    }*/

    /*void ShotGun()
    {
        //¼¦°Ç ÄÚµå
        shotGun.gameObject.transform.position = mob.gameObject.transform.position;
        shotGun2.gameObject.transform.position = mob.gameObject.transform.position;
        shotGun3.gameObject.transform.position = mob.gameObject.transform.position;
        Vector3 start = shotGun.transform.position;
        Vector3 end = mob.target.transform.position;
        Vector3 fin = end - start;
        shotGun.transform.rotation = Quaternion.Euler(shotGun.transform.rotation.x, shotGun.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + -30);
        shotGun2.transform.rotation = Quaternion.Euler(shotGun2.transform.rotation.x, shotGun2.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 210);
        shotGun3.transform.rotation = Quaternion.Euler(shotGun3.transform.rotation.x, shotGun3.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
        shotGun.gameObject.SetActive(true);
        shotGun2.gameObject.SetActive(true);
        shotGun3.gameObject.SetActive(true);
    }

    

    void GunGroup()
    {
        //ÃÑ¾Ë ¹«´õ±â
        gunGroup.gameObject.transform.position = mob.gameObject.transform.position;
        gunGroup.gameObject.SetActive(true);
    }*/
}
