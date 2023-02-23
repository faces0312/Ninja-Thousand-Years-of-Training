using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Boss_Laser : MonoBehaviour
{
    public GameObject laser1;
    public GameObject laser2;
    public GameObject laser3;
    public GameObject laser4;
    public GameObject laser5;
    public GameObject laser6;

    private void OnEnable()
    {
        StartCoroutine(nameof(Dis_Laser));
    }


    private void Update()
    {
        laser1.transform.Rotate(0, 0, 30 * Time.deltaTime);
        laser2.transform.Rotate(0, 0, 30 * Time.deltaTime);
        laser3.transform.Rotate(0, 0, 30 * Time.deltaTime);
        laser4.transform.Rotate(0, 0, 30 * Time.deltaTime);
        laser5.transform.Rotate(0, 0, 30 * Time.deltaTime);
        laser6.transform.Rotate(0, 0, 30 * Time.deltaTime);
    }

    IEnumerator Dis_Laser()
    {
        yield return new WaitForSeconds(4f);
        gameObject.SetActive(false);
    }
}
