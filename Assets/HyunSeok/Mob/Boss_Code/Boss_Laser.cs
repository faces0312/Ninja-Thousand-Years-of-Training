using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Laser : MonoBehaviour
{
    public Bat_Boss_Area bat;
    bool is_rotate;
    private void OnEnable()
    {
        is_rotate = false;
        StartCoroutine(nameof(Laser));
        StartCoroutine(nameof(Dis_Laser));
    }

    private void Update()
    {
        if(is_rotate == true)
        {
            if(bat.laser_ran == 0)
                transform.Rotate(0, 0, 45 * Time.deltaTime);
            else
                transform.Rotate(0, 0, -45 * Time.deltaTime);
        }
    }

    IEnumerator Laser()
    {
        yield return new WaitForSeconds(0.5f);
        is_rotate = true;
    }

    IEnumerator Dis_Laser()
    {
        yield return new WaitForSeconds(3f);
        Manager.manager.sound.bossLaser.Stop();
        gameObject.SetActive(false);
    }
}
