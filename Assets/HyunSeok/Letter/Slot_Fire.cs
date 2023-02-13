using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Fire : MonoBehaviour
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
            if (result_obj[0].gameObject.activeSelf == true)
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
            if (result_obj[1].gameObject.activeSelf == true)
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
            if (result_obj[2].gameObject.activeSelf == true)
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
        }
        close_page.gameObject.SetActive(true);
    }

    public void Close_Page()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
