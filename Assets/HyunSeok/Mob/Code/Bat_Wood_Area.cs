using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Wood_Area : MonoBehaviour
{
    public Bat_Wood mob;
    public Mob_Atk atk;

    public float atk_CT;
    private float atk_Tmp_CT;


    //bool is_area;
    
    private void OnEnable()
    {
        atk_CT = 5f;
        atk_Tmp_CT = atk_CT;
    }
    private void Update()
    {
        if((mob.target.transform.position - gameObject.transform.position).sqrMagnitude < 3f)
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
        }
        else
            mob.target_on = true;
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
}
