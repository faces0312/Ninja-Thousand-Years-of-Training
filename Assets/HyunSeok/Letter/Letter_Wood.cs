using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Wood : MonoBehaviour
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
                if (Data.Instance.gameData.wind_lv < 6)
                {
                    Data.Instance.gameData.wind_lv++;
                    if (Data.Instance.gameData.wind_lv == 2)
                        Manager.manager.objectManager.wind_CT = 15f;
                    else if (Data.Instance.gameData.wind_lv == 3)
                        Manager.manager.objectManager.wind_CT = 12f;
                    else if (Data.Instance.gameData.wind_lv == 4)
                        Manager.manager.objectManager.wind_CT = 10f;
                    else if (Data.Instance.gameData.wind_lv == 5)
                        Manager.manager.objectManager.wind_CT = 9f;
                    else if (Data.Instance.gameData.wind_lv == 6)
                        Manager.manager.objectManager.wind_CT = 8f;
                }
            }
            if (ran_skill == 1)
            {
                if (Data.Instance.gameData.windwall_lv < 6)
                {
                    Data.Instance.gameData.windwall_lv++;
                    if (Data.Instance.gameData.windwall_lv == 2)
                        Manager.manager.objectManager.windwall_CT = 18f;
                    else if (Data.Instance.gameData.windwall_lv == 3)
                        Manager.manager.objectManager.windwall_CT = 16f;
                    else if (Data.Instance.gameData.windwall_lv == 4)
                        Manager.manager.objectManager.windwall_CT = 15f;
                    else if (Data.Instance.gameData.windwall_lv == 5)
                        Manager.manager.objectManager.windwall_CT = 12f;
                    else if (Data.Instance.gameData.windwall_lv == 6)
                        Manager.manager.objectManager.windwall_CT = 10f;
                }
            }
            if (ran_skill == 2)
            {
                if (Data.Instance.gameData.tree_lv < 6)
                {
                    Data.Instance.gameData.tree_lv++;
                    if (Data.Instance.gameData.tree_lv == 2)
                        Manager.manager.objectManager.tree_CT = 65f;
                    else if (Data.Instance.gameData.tree_lv == 3)
                        Manager.manager.objectManager.tree_CT = 60f;
                    else if (Data.Instance.gameData.tree_lv == 4)
                        Manager.manager.objectManager.tree_CT = 60f;
                    else if (Data.Instance.gameData.tree_lv == 5)
                        Manager.manager.objectManager.tree_CT = 55f;
                    else if (Data.Instance.gameData.tree_lv == 6)
                        Manager.manager.objectManager.tree_CT = 50f;
                }
            }
            letter_body.gameObject.SetActive(false);
        }
    }
}
