using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Fire : MonoBehaviour
{
    public GameObject letter_body;
    int ran_skill;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBody")
        {
            ran_skill = Random.Range(0, 3);
            if (ran_skill == 0)
            {
                if (Data.Instance.gameData.fire_lv < 6)
                {
                    Data.Instance.gameData.fire_lv++;
                    if (Data.Instance.gameData.fire_lv == 2)
                        Manager.manager.objectManager.fire_CT = 7f;
                    else if (Data.Instance.gameData.fire_lv == 3)
                        Manager.manager.objectManager.fire_CT = 7f;
                    else if (Data.Instance.gameData.fire_lv == 4)
                        Manager.manager.objectManager.fire_CT = 5f;
                    else if (Data.Instance.gameData.fire_lv == 5)
                        Manager.manager.objectManager.fire_CT = 5f;
                    else if (Data.Instance.gameData.fire_lv == 6)
                        Manager.manager.objectManager.fire_CT = 5f;
                }
            }
            if (ran_skill == 1)
            {
                if (Data.Instance.gameData.talisman_lv < 6)
                {
                    Data.Instance.gameData.talisman_lv++;
                    if (Data.Instance.gameData.talisman_lv == 2)
                        Manager.manager.objectManager.talisman_CT = 15f;
                    else if (Data.Instance.gameData.talisman_lv == 3)
                        Manager.manager.objectManager.talisman_CT = 12f;
                    else if (Data.Instance.gameData.talisman_lv == 4)
                        Manager.manager.objectManager.talisman_CT = 10f;
                    else if (Data.Instance.gameData.talisman_lv == 5)
                        Manager.manager.objectManager.talisman_CT = 9f;
                    else if (Data.Instance.gameData.talisman_lv == 6)
                        Manager.manager.objectManager.talisman_CT = 7f;
                }
            }
            if (ran_skill == 2)
            {
                if (Data.Instance.gameData.fire_column_lv < 6)
                {
                    Data.Instance.gameData.fire_column_lv++;
                    if (Data.Instance.gameData.fire_column_lv == 2)
                        Manager.manager.objectManager.firecolumn_CT = 9f;
                    else if (Data.Instance.gameData.fire_column_lv == 3)
                        Manager.manager.objectManager.firecolumn_CT = 8f;
                    else if (Data.Instance.gameData.fire_column_lv == 4)
                        Manager.manager.objectManager.firecolumn_CT = 7f;
                    else if (Data.Instance.gameData.fire_column_lv == 5)
                        Manager.manager.objectManager.firecolumn_CT = 6f;
                    else if (Data.Instance.gameData.fire_column_lv == 6)
                        Manager.manager.objectManager.firecolumn_CT = 5f;
                }
            }
            letter_body.gameObject.SetActive(false);
        }
    }
}
