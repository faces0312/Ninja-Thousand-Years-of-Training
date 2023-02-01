using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_NormalAtk : MonoBehaviour
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
            }
            if (ran_skill == 1)
            {
                if (Data.Instance.gameData.shadow_partner_lv < 6)
                {
                    Data.Instance.gameData.shadow_partner_lv++;
                    if (Data.Instance.gameData.shadow_partner_lv == 1)
                        Manager.manager.player.shadowPartner1.gameObject.SetActive(true);
                    if (Data.Instance.gameData.shadow_partner_lv == 2)
                        Manager.manager.objectManager.shadow_partner_CT = 0.8f;
                    else if (Data.Instance.gameData.shadow_partner_lv == 3)
                        Manager.manager.objectManager.shadow_partner_CT = 0.5f;
                    else if (Data.Instance.gameData.shadow_partner_lv == 4)
                    {
                        Manager.manager.objectManager.shadow_partner_CT = 0.5f;
                        Manager.manager.player.shadowPartner2.gameObject.SetActive(true);
                    }
                    else if (Data.Instance.gameData.shadow_partner_lv == 5)
                        Manager.manager.objectManager.shadow_partner_CT = 0.3f;
                    else if (Data.Instance.gameData.shadow_partner_lv == 6)
                        Manager.manager.objectManager.shadow_partner_CT = 0.1f;
                }
            }
            if (ran_skill == 2)
            {
                if (Data.Instance.gameData.boomerang_lv < 6)
                {
                    Data.Instance.gameData.boomerang_lv++;
                    if (Data.Instance.gameData.boomerang_lv == 2)
                        Manager.manager.objectManager.boomerang_CT = 9f;
                    else if (Data.Instance.gameData.boomerang_lv == 3)
                        Manager.manager.objectManager.boomerang_CT = 8f;
                    else if (Data.Instance.gameData.boomerang_lv == 4)
                        Manager.manager.objectManager.boomerang_CT = 7f;
                    else if (Data.Instance.gameData.boomerang_lv == 5)
                        Manager.manager.objectManager.boomerang_CT = 6f;
                    else if (Data.Instance.gameData.boomerang_lv == 6)
                        Manager.manager.objectManager.boomerang_CT = 5f;
                }
            }

            letter_body.gameObject.SetActive(false);
        }
    }
}
