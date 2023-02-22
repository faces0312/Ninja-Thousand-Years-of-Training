using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_GunGroup_Attack : MonoBehaviour
{
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject attack4;
    public GameObject attack5;
    public GameObject attack6;
    public GameObject attack7;
    public GameObject attack8;

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

        attack1.SetActive(true);
        attack2.SetActive(true);
        attack3.SetActive(true);
        attack4.SetActive(true);
        attack5.SetActive(true);
        attack6.SetActive(true);
        attack7.SetActive(true);
        attack8.SetActive(true);
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * 15 * Time.deltaTime);
    }
}
