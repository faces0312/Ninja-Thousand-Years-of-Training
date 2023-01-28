using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Mecha_Area : MonoBehaviour
{
    public Bat_Mecha mob;
    public Mob_Atk atk;

    public float atk_CT;
    private float atk_Tmp_CT;

    private void OnEnable()
    {
        atk_CT = 5f;
        atk_Tmp_CT = atk_CT;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            mob.target_on = false;
            if (atk_Tmp_CT > 0)
                atk_Tmp_CT -= Time.deltaTime;
            else
            {
                atk.gameObject.transform.position = mob.gameObject.transform.position;
                Vector3 start = atk.transform.position;
                Vector3 end = collision.transform.position;
                Vector3 fin = end - start;
                atk.transform.rotation = Quaternion.Euler(atk.transform.rotation.x, atk.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
                atk.gameObject.SetActive(true);
                atk_Tmp_CT = atk_CT;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            mob.target_on = true;
        }
    }
}
