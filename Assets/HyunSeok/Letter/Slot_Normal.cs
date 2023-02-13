using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Normal : MonoBehaviour
{
    int ran_num;//결정지울 숫자
    public GameObject[] result_obj;//슬롯 결과 이미지들
    public GameObject close_page;

    private void OnEnable()
    {
        ran_num = Random.Range(0, 3);
        Time.timeScale = 0;
        close_page.gameObject.SetActive(false);
        for(int i=0;i<3;i++)
            result_obj[i].gameObject.SetActive(false);
        StartCoroutine(Start_Slot());
    }

    IEnumerator Start_Slot()
    {
        if(ran_num == 0)
        {
            result_obj[0].gameObject.SetActive(true);
            for (float i = 0.4f; i < 1f; i += 0.05f)
            {
                result_obj[0].gameObject.transform.localScale = new Vector3(i, i);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            yield return new WaitForSecondsRealtime(0.1f);
            Yes();
        }
        else if (ran_num == 1)
        {
            result_obj[1].gameObject.SetActive(true);
            for (float i = 0.4f; i < 1f; i += 0.05f)
            {
                result_obj[1].gameObject.transform.localScale = new Vector3(i, i);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            yield return new WaitForSecondsRealtime(0.1f);
            Yes();
        }
        else if (ran_num == 2)
        {
            result_obj[2].gameObject.SetActive(true);
            for (float i = 0.4f; i < 1f ; i += 0.05f)
            {
                result_obj[2].gameObject.transform.localScale = new Vector3(i, i);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            yield return new WaitForSecondsRealtime(0.1f); 
            Yes();
        }

    }

    public void Yes()
    {
        if (result_obj[0].gameObject.activeSelf == true)
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
        if (result_obj[1].gameObject.activeSelf == true)
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
        if (result_obj[2].gameObject.activeSelf == true)
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

        close_page.gameObject.SetActive(true);
    }

    public void Close_Page()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

}
