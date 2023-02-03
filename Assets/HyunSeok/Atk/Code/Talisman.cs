using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talisman : MonoBehaviour
{
    public GameObject talisman_boom;
    private bool move_talisman;
    private void OnEnable()
    {
        StartCoroutine("Talisman_Boom");
        move_talisman = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(move_talisman == true)
            transform.Translate(Vector3.up * 13 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mob1" || collision.tag == "Bat_Body")
        {
            move_talisman = false;
            StopCoroutine("Talisman_Boom");
            talisman_boom.gameObject.SetActive(true);
        }
    }

    IEnumerator Talisman_Boom()
    {
        yield return new WaitForSeconds(0.2f);
        move_talisman = false;
        talisman_boom.gameObject.SetActive(true);
    }
}
