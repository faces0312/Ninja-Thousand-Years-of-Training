using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_Cremore : MonoBehaviour
{
    public Vector2 move_vector;

    public GameObject big_attack;
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject attack4;
    public GameObject attack5;
    public GameObject attack6;

    private void OnEnable()
    {
        move_vector = Manager.manager.objectManager.player_vector;

        big_attack.transform.position = gameObject.transform.position;

        attack1.gameObject.transform.localEulerAngles = new Vector3(0, 0, 60);
        attack2.gameObject.transform.localEulerAngles = new Vector3(0, 0, 120);
        attack3.gameObject.transform.localEulerAngles = new Vector3(0, 0, 180);
        attack4.gameObject.transform.localEulerAngles = new Vector3(0, 0, 240);
        attack5.gameObject.transform.localEulerAngles = new Vector3(0, 0, 300);
        attack6.gameObject.transform.localEulerAngles = new Vector3(0, 0, 360);

        attack1.gameObject.SetActive(false);
        attack2.gameObject.SetActive(false);
        attack3.gameObject.SetActive(false);
        attack4.gameObject.SetActive(false);
        attack5.gameObject.SetActive(false);
        attack6.gameObject.SetActive(false);

        big_attack.gameObject.SetActive(true);

        StartCoroutine(Dis_Cremore());
    }

    IEnumerator Dis_Cremore()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}
