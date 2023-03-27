using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_GunGroup_Atk : MonoBehaviour
{
    public Boss_GunGroup boss;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * 1.15f * Time.deltaTime);
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
