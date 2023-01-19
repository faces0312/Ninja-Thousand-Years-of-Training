using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal_Atk : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine("Dis_Atk");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 0, 10 , Space.Self);
        transform.Translate(Vector3.right * 8 * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mob")
        {
            StopCoroutine("Dis_Atk");
            gameObject.SetActive(false);
        }
    }

    IEnumerator Dis_Atk()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}