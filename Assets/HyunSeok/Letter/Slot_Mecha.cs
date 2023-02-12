using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Mecha : MonoBehaviour
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
        mid = -875;
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

        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void No()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
