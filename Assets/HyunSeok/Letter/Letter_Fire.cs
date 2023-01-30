using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Fire : MonoBehaviour
{
    public GameObject letter_body;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            if (Data.Instance.gameData.normal_atk_lv < 6)
            {
                Data.Instance.gameData.normal_atk_lv++;
                if (Data.Instance.gameData.normal_atk_lv == 2)
                    Manager.manager.objectManager.atk_normal_CT = 0.45f;
                else if (Data.Instance.gameData.normal_atk_lv == 3)
                    Manager.manager.objectManager.atk_normal_CT = 0.4f;
                else if (Data.Instance.gameData.normal_atk_lv == 4)
                    Manager.manager.objectManager.atk_normal_CT = 0.35f;
                else if (Data.Instance.gameData.normal_atk_lv == 5)
                    Manager.manager.objectManager.atk_normal_CT = 0.3f;
                else if (Data.Instance.gameData.normal_atk_lv == 6)
                    Manager.manager.objectManager.atk_normal_CT = 0.1f;
            }
            letter_body.gameObject.SetActive(false);
        }
    }
}
