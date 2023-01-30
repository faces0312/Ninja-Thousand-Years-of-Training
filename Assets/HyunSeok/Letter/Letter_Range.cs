using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Range : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(nameof(Down));
    }

    IEnumerator Down()
    {
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0, -1 * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(nameof(Up));
    }

    IEnumerator Up()
    {
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0, 1 * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(nameof(Down));
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody" )
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, collision.transform.position, 4 * Time.deltaTime);
        }
    }
}
