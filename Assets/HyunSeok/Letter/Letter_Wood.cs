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
                        Manager.manager.objectManager.atk_normal_CT = 0.45f;
                    else if (Data.Instance.gameData.wind_lv == 3)
                        Manager.manager.objectManager.atk_normal_CT = 0.4f;
                    else if (Data.Instance.gameData.wind_lv == 4)
                        Manager.manager.objectManager.atk_normal_CT = 0.35f;
                    else if (Data.Instance.gameData.wind_lv == 5)
                        Manager.manager.objectManager.atk_normal_CT = 0.3f;
                    else if (Data.Instance.gameData.wind_lv == 6)
                        Manager.manager.objectManager.atk_normal_CT = 0.1f;
                }
            }
            if (ran_skill == 1)
            {
                if (Data.Instance.gameData.windwall_lv < 6)
                {
                    Data.Instance.gameData.windwall_lv++;
                    if (Data.Instance.gameData.windwall_lv == 2)
                        Manager.manager.objectManager.atk_normal_CT = 0.45f;
                    else if (Data.Instance.gameData.windwall_lv == 3)
                        Manager.manager.objectManager.atk_normal_CT = 0.4f;
                    else if (Data.Instance.gameData.windwall_lv == 4)
                        Manager.manager.objectManager.atk_normal_CT = 0.35f;
                    else if (Data.Instance.gameData.windwall_lv == 5)
                        Manager.manager.objectManager.atk_normal_CT = 0.3f;
                    else if (Data.Instance.gameData.windwall_lv == 6)
                        Manager.manager.objectManager.atk_normal_CT = 0.1f;
                }
            }
            if (ran_skill == 2)
            {
                if (Data.Instance.gameData.tree_lv < 6)
                {
                    Data.Instance.gameData.tree_lv++;
                    if (Data.Instance.gameData.tree_lv == 2)
                        Manager.manager.objectManager.atk_normal_CT = 0.45f;
                    else if (Data.Instance.gameData.tree_lv == 3)
                        Manager.manager.objectManager.atk_normal_CT = 0.4f;
                    else if (Data.Instance.gameData.tree_lv == 4)
                        Manager.manager.objectManager.atk_normal_CT = 0.35f;
                    else if (Data.Instance.gameData.tree_lv == 5)
                        Manager.manager.objectManager.atk_normal_CT = 0.3f;
                    else if (Data.Instance.gameData.tree_lv == 6)
                        Manager.manager.objectManager.atk_normal_CT = 0.1f;
                }
            }
            letter_body.gameObject.SetActive(false);
        }
    }
}
