using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Mecha : MonoBehaviour
{
    public GameObject letter_body;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            Manager.manager.slot_Mecha.gameObject.SetActive(true);
            letter_body.gameObject.SetActive(false);
        }
    }
}
