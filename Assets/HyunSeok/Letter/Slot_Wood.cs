using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Wood : MonoBehaviour
{
    int ran_num;//결정지울 숫자
    public GameObject[] result_obj;//슬롯 결과 이미지들
    public GameObject close_page;

    private void OnEnable()
    {
        ran_num = Random.Range(0, 3);
        Time.timeScale = 0;
        close_page.gameObject.SetActive(false);
        for (int i = 0; i < 3; i++)
            result_obj[i].gameObject.SetActive(false);
        StartCoroutine(Start_Slot());
    }

    IEnumerator Start_Slot()
    {
        if (ran_num == 0)
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
            for (float i = 0.4f; i < 1f; i += 0.05f)
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
        if (result_obj[1].gameObject.activeSelf == true)
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
        if (result_obj[2].gameObject.activeSelf == true)
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

        close_page.gameObject.SetActive(true);
    }

    public void Close_Page()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
