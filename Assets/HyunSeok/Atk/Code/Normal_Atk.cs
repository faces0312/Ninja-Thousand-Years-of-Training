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


    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mob1" || collision.tag == "Bat_Body")
        {
            gameObject.SetActive(false);
        }
    }*/

    IEnumerator Dis_Atk()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
}