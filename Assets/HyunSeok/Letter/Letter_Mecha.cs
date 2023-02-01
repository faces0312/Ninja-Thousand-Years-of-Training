using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Mecha : MonoBehaviour
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
                if (Data.Instance.gameData.tornado_lv < 6)
                {
                    Data.Instance.gameData.tornado_lv++;
                    if (Data.Instance.gameData.tornado_lv == 2)
                        Manager.manager.objectManager.tornado_CT = 9f;
                    else if (Data.Instance.gameData.tornado_lv == 3)
                        Manager.manager.objectManager.tornado_CT = 8f;
                    else if (Data.Instance.gameData.tornado_lv == 4)
                        Manager.manager.objectManager.tornado_CT = 7f;
                    else if (Data.Instance.gameData.tornado_lv == 5)
                        Manager.manager.objectManager.tornado_CT = 6f;
                    else if (Data.Instance.gameData.tornado_lv == 6)
                        Manager.manager.objectManager.tornado_CT = 5f;
                }
            }
            if (ran_skill == 1)
            {
                if (Data.Instance.gameData.voltTackle_lv < 6)
                {
                    Data.Instance.gameData.voltTackle_lv++;
                    if (Data.Instance.gameData.voltTackle_lv == 2)
                        Manager.manager.player.volttackle_CT = 21f;
                    else if (Data.Instance.gameData.voltTackle_lv == 3)
                        Manager.manager.player.volttackle_CT = 18f;
                    else if (Data.Instance.gameData.voltTackle_lv == 4)
                        Manager.manager.player.volttackle_CT = 17f;
                    else if (Data.Instance.gameData.voltTackle_lv == 5)
                        Manager.manager.player.volttackle_CT = 16f;
                    else if (Data.Instance.gameData.voltTackle_lv == 6)
                        Manager.manager.player.volttackle_CT = 15f;
                }
            }
            if (ran_skill == 2)
            {
                if (Data.Instance.gameData.electricity_lv < 6)
                {
                    Data.Instance.gameData.electricity_lv++;
                    if (Data.Instance.gameData.electricity_lv == 2)
                        Manager.manager.objectManager.electricity_CT = 21f;
                    else if (Data.Instance.gameData.electricity_lv == 3)
                        Manager.manager.objectManager.electricity_CT = 18f;
                    else if (Data.Instance.gameData.electricity_lv == 4)
                        Manager.manager.objectManager.electricity_CT = 17f;
                    else if (Data.Instance.gameData.electricity_lv == 5)
                        Manager.manager.objectManager.electricity_CT = 16f;
                    else if (Data.Instance.gameData.electricity_lv == 6)
                        Manager.manager.objectManager.electricity_CT = 15f;
                }
            }
            letter_body.gameObject.SetActive(false);
        }
    }
}
