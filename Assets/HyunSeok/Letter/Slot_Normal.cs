using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Normal : MonoBehaviour
{
    int ran_num;//룰렛을 얼마나 돌릴지 결정하는 숫자

    public GameObject start_Y;//슬롯 이미지 시작 위치
    public GameObject end_Y;//슬록 이미지 끝 위치

    public GameObject slot_skill;
    public GameObject[] slot_obj;//슬롯 이미지들 0 : 일반공격, 1 : 분신 공격, 3 : 부메랑

    private float mid;//가운데 이미지 벡터
    private float dif1;//차이 1 
    private float dif2;//차이 2 
    private float dif3;//차이 3

    public GameObject[] result_obj;//슬롯 결과 이미지들

    public Button yes_button;
    public Button no_button;

    private void OnEnable()
    {
        ran_num = Random.Range(80, 120);

        Time.timeScale = 0;
        slot_skill.gameObject.SetActive(true);
        slot_obj[0].transform.localPosition = new Vector3(125, -375);
        slot_obj[1].transform.localPosition = new Vector3(125, -625);
        slot_obj[2].transform.localPosition = new Vector3(125, -875);
        for (int i = 0; i < 3; i++)
            result_obj[i].gameObject.SetActive(false);
        yes_button.interactable = false;
        no_button.interactable = false;
        mid = -825;
        StartCoroutine(Start_Slot());
    }

    IEnumerator Start_Slot()
    {
        for(int i = 0; i < ran_num; i++)
        {
            slot_obj[0].transform.localPosition -= new Vector3(0, 50f, 0);
            slot_obj[1].transform.localPosition -= new Vector3(0, 50f, 0);
            slot_obj[2].transform.localPosition -= new Vector3(0, 50f, 0);

            if (slot_obj[0].transform.position.y <= end_Y.transform.position.y)
                slot_obj[0].transform.position = new Vector3(slot_obj[0].transform.position.x, start_Y.transform.position.y - 250);
            if (slot_obj[1].transform.position.y <= end_Y.transform.position.y)
                slot_obj[1].transform.position = new Vector3(slot_obj[1].transform.position.x, start_Y.transform.position.y - 250);
            if (slot_obj[2].transform.position.y <= end_Y.transform.position.y)
                slot_obj[2].transform.position = new Vector3(slot_obj[2].transform.position.x, start_Y.transform.position.y - 250);
            yield return new WaitForSecondsRealtime(0.01f);
        }

        dif1 = (slot_obj[0].transform.localPosition.y - mid);
        dif2 = (slot_obj[1].transform.localPosition.y - mid);
        dif3 = (slot_obj[2].transform.localPosition.y - mid);

        yield return new WaitForSecondsRealtime(1f);

        if (dif1 > dif2)
        {
            if (dif2 > dif3)
                result_obj[2].gameObject.SetActive(true);
            else
                result_obj[1].gameObject.SetActive(true);
        }
        else
        {
            if (dif1 > dif3)
                result_obj[2].gameObject.SetActive(true);
            else
                result_obj[0].gameObject.SetActive(true);
        }

        slot_skill.gameObject.SetActive(false);

        yes_button.interactable = true;
        no_button.interactable = true;
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

        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void No()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
