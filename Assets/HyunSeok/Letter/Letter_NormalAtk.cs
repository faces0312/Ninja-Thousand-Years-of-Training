using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_NormalAtk : MonoBehaviour
{
    public GameObject letter_body;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            Manager.manager.slot_Normal.gameObject.SetActive(true);
            letter_body.gameObject.SetActive(false);
        }
    }
}
