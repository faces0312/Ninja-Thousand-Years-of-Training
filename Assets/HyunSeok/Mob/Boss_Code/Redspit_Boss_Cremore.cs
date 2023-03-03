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
        attack1.transform.position = gameObject.transform.position;
        attack2.transform.position = gameObject.transform.position;
        attack3.transform.position = gameObject.transform.position;
        attack4.transform.position = gameObject.transform.position;
        attack5.transform.position = gameObject.transform.position;
        attack6.transform.position = gameObject.transform.position;

        big_attack.gameObject.SetActive(true);
        attack1.gameObject.SetActive(false);
        attack2.gameObject.SetActive(false);
        attack3.gameObject.SetActive(false);
        attack4.gameObject.SetActive(false);
        attack5.gameObject.SetActive(false);
        attack6.gameObject.SetActive(false);

        StartCoroutine(Dis_Cremore());
    }

    IEnumerator Dis_Cremore()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if ((transform.position.x != move_vector.x) && (transform.position.y != move_vector.y))
            transform.position = Vector3.MoveTowards(transform.position, move_vector, 3 * Time.deltaTime);
        else
        {
            big_attack.gameObject.SetActive(false);
            attack1.gameObject.SetActive(true);
            attack2.gameObject.SetActive(true);
            attack3.gameObject.SetActive(true);
            attack4.gameObject.SetActive(true);
            attack5.gameObject.SetActive(true);
            attack6.gameObject.SetActive(true);
        }
    }
}
