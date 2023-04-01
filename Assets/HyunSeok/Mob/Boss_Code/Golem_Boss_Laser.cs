using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Boss_Laser : MonoBehaviour
{
    public Golem_Boss_Area golem;

    public GameObject laser1;
    public GameObject laser2;
    public GameObject laser3;
    public GameObject laser4;
    public GameObject laser5;
    public GameObject laser6;

    private void OnEnable()
    {
        StartCoroutine(nameof(Dis_Laser));

        laser1.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.35f);
        laser2.gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y + 0.2f);
        laser3.gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y - 0.2f);
        laser4.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.35f);
        laser5.gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.3f, gameObject.transform.position.y - 0.2f);
        laser6.gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.3f, gameObject.transform.position.y + 0.2f);

        laser1.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        laser2.gameObject.transform.rotation = Quaternion.Euler(0, 0, 120);
        laser3.gameObject.transform.rotation = Quaternion.Euler(0, 0, 60);
        laser4.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        laser5.gameObject.transform.rotation = Quaternion.Euler(0, 0, -60);
        laser6.gameObject.transform.rotation = Quaternion.Euler(0, 0, -120);
    }


    private void Update()
    {
        if(golem.laser_ran == 0)
        {
            laser1.transform.Rotate(0, 0, 30 * Time.deltaTime);
            laser2.transform.Rotate(0, 0, 30 * Time.deltaTime);
            laser3.transform.Rotate(0, 0, 30 * Time.deltaTime);
            laser4.transform.Rotate(0, 0, 30 * Time.deltaTime);
            laser5.transform.Rotate(0, 0, 30 * Time.deltaTime);
            laser6.transform.Rotate(0, 0, 30 * Time.deltaTime);
        }
        else
        {
            laser1.transform.Rotate(0, 0, -30 * Time.deltaTime);
            laser2.transform.Rotate(0, 0, -30 * Time.deltaTime);
            laser3.transform.Rotate(0, 0, -30 * Time.deltaTime);
            laser4.transform.Rotate(0, 0, -30 * Time.deltaTime);
            laser5.transform.Rotate(0, 0, -30 * Time.deltaTime);
            laser6.transform.Rotate(0, 0, -30 * Time.deltaTime);
        }
    }

    IEnumerator Dis_Laser()
    {
        yield return new WaitForSeconds(4f);
        Manager.manager.sound.bossLaser.Stop();
        gameObject.SetActive(false);
    }
}
