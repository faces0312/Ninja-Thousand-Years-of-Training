using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Wood : MonoBehaviour
{
    int ran_num;//�귿�� �󸶳� ������ �����ϴ� ����

    public GameObject start_Y;//���� �̹��� ���� ��ġ
    public GameObject end_Y;//���� �̹��� �� ��ġ

    public GameObject slot_skill;
    public GameObject[] slot_obj;//���� �̹����� 0 : �Ϲݰ���, 1 : �н� ����, 3 : �θ޶�

    private float mid;//��� �̹��� ����
    private float dif1;//���� 1 
    private float dif2;//���� 2 
    private float dif3;//���� 3

    public GameObject[] result_obj;//���� ��� �̹�����

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
        for (int i = 0; i < ran_num; i++)
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

        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void No()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
