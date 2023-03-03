using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Wall : MonoBehaviour
{
    public Player player;
    public Mob_Atk atk;

    public float atk_CT;
    private float atk_Tmp_CT;


    //bool is_area;

    private void OnEnable()
    {
        atk_CT = 2f;
        atk_Tmp_CT = atk_CT;
    }
    private void Update()
    {
        if ((player.transform.position - gameObject.transform.position).sqrMagnitude < 3f)
        {
            if (atk_Tmp_CT > 0)
                atk_Tmp_CT -= Time.deltaTime;
            else
            {
                atk.gameObject.transform.position = gameObject.transform.position;
                Vector3 start = atk.transform.position;
                Vector3 end = player.transform.position;
                Vector3 fin = end - start;
                atk.transform.rotation = Quaternion.Euler(atk.transform.rotation.x, atk.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
                atk.gameObject.SetActive(true);
                atk_Tmp_CT = atk_CT;
            }
        }
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
}
