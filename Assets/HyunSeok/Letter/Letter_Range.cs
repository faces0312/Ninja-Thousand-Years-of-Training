using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Range : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(nameof(Dis_Letter));
        StartCoroutine(nameof(Down));
    }

    IEnumerator Down()
    {
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0, -0.4f * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(nameof(Up));
    }

    IEnumerator Up()
    {
        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0, 0.4f * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(nameof(Down));
    }

    IEnumerator Dis_Letter()
    {
        yield return new WaitForSeconds(30f);
        gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody" )
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, collision.transform.position, 4 * Time.deltaTime);
        }
    }
}
