using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_ShotGun_Attack : MonoBehaviour
{

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * 1.1f * Time.deltaTime);
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
    }
}
