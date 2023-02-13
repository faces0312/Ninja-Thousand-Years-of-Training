using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Mecha : MonoBehaviour
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
        if (result_obj[1].gameObject.activeSelf == true)
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
        if (result_obj[2].gameObject.activeSelf == true)
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

        close_page.gameObject.SetActive(true);
    }
    //
    public void Close_Page()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
