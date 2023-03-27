using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Boss_Area : MonoBehaviour
{
    public Golem_Boss mob;

    /*public Boss_ShotGun shotGun;
    public Boss_ShotGun shotGun2;
    public Boss_ShotGun shotGun3;
    public Boss_Laser laser;
    public Boss_GunGroup gunGroup;*/

    public Golem_Boss_Laser laser;

    int atk_ran;

    public float atk_CT;
    private float atk_Tmp_CT;

    public int laser_ran;
    //bool is_area;
    private void OnEnable()
    {
        atk_CT = 8f;
        atk_Tmp_CT = 1f;
    }
    private void FixedUpdate()
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
                    Manager.manager.objectManager.Golem_Boss_Lighting_General(mob.gameObject.transform.position);
                else if (atk_ran == 1)
                    Manager.manager.objectManager.Golem_Boss_Wire_General(mob.gameObject.transform.position);
                else if (atk_ran == 2)
                    Laser();


                atk_Tmp_CT = atk_CT;
            }
        }
        else
            mob.target_on = true;
    }

    void Laser()
    {
        laser_ran = Random.Range(0, 2);
        //¼¦°Ç ÄÚµå
        laser.gameObject.transform.position = new Vector3(mob.gameObject.transform.position.x - 0.05f, mob.gameObject.transform.position.y - 0.25f);

        laser.gameObject.SetActive(true);
    }
}
