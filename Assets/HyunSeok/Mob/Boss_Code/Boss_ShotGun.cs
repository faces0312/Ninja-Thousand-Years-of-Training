using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_ShotGun : MonoBehaviour
{
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject attack4;
    public GameObject attack5;
    public GameObject attack6;
    public GameObject attack7;
    public GameObject attack8;
    public GameObject attack9;
    public GameObject attack10;
    public GameObject attack11;
    public GameObject attack12;
    public GameObject attack13;
    public GameObject attack14;
    public GameObject attack15;
    public GameObject attack16;
    public GameObject attack17;
    public GameObject attack18;

    private void OnEnable()
    {
        attack1.gameObject.transform.position = gameObject.transform.position;
        attack2.gameObject.transform.position = gameObject.transform.position;
        attack3.gameObject.transform.position = gameObject.transform.position;
        attack4.gameObject.transform.position = gameObject.transform.position;
        attack5.gameObject.transform.position = gameObject.transform.position;
        attack6.gameObject.transform.position = gameObject.transform.position;
        attack7.gameObject.transform.position = gameObject.transform.position;
        attack8.gameObject.transform.position = gameObject.transform.position;
        attack9.gameObject.transform.position = gameObject.transform.position;
        attack10.gameObject.transform.position = gameObject.transform.position;
        attack11.gameObject.transform.position = gameObject.transform.position;
        attack12.gameObject.transform.position = gameObject.transform.position;
        attack13.gameObject.transform.position = gameObject.transform.position;
        attack14.gameObject.transform.position = gameObject.transform.position;
        attack15.gameObject.transform.position = gameObject.transform.position;
        attack16.gameObject.transform.position = gameObject.transform.position;
        attack17.gameObject.transform.position = gameObject.transform.position;
        attack18.gameObject.transform.position = gameObject.transform.position;

        attack1.SetActive(true);
        attack2.SetActive(true);
        attack3.SetActive(true);
        attack4.SetActive(true);
        attack5.SetActive(true);
        attack6.SetActive(true);
        attack7.SetActive(true);
        attack8.SetActive(true);
        attack9.SetActive(true);
        attack10.SetActive(true);
        attack11.SetActive(true);
        attack12.SetActive(true);
        attack13.SetActive(true);
        attack14.SetActive(true);
        attack15.SetActive(true);
        attack16.SetActive(true);
        attack17.SetActive(true);
        attack18.SetActive(true);

        StartCoroutine(Dis_Atk());
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * 0.4f * Time.deltaTime);
    }

    IEnumerator Dis_Atk()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }

}
