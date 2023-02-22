using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Atk : MonoBehaviour
{  //Åº ÄÚµå
    private void OnEnable()
    {
        StartCoroutine(Dis_Atk());
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }

    IEnumerator Dis_Atk()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            gameObject.SetActive(false);
        }

    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WindWall")
        {
            gameObject.SetActive(false);
        }
        /*if (collision.gameObject.tag == "PlayerBody")
        {
            gameObject.SetActive(false);
        }*/
    }
}
