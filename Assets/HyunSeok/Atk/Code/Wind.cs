using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    bool is_back;

    private void OnEnable()
    {
        is_back = false;
        StartCoroutine(Move_Go());
    }

    void Update()
    {
        if(is_back == false)
        {
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, Manager.manager.player.transform.position, 5 * Time.deltaTime);
        }
    }

    IEnumerator Move_Go()
    {
        yield return new WaitForSeconds(0.4f);
        is_back = true;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBody" && is_back == true)
        {
            gameObject.SetActive(false);
        }
    }
}
