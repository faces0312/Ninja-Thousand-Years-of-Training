using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slot_Mecha : MonoBehaviour
{
    int ran_num;//�������� ����
    public GameObject[] result_obj;//���� ��� �̹�����
    public GameObject close_page;
    public TextMeshProUGUI[] result_text;

    public int tornado_num;//���° ��������
    public int volttackle_num;//���° ��������
    public int electricity_num;
    private void OnEnable()
    {
        if (Data.Instance.gameData.skill_cnt == 6)//��ųī��Ʈ�� ��á�� ��
        {
            if ((Data.Instance.gameData.tornado_lv == 6 || Data.Instance.gameData.tornado_lv == 0) &&
                (Data.Instance.gameData.voltTackle_lv == 6 || Data.Instance.gameData.voltTackle_lv == 0) &&
                (Data.Instance.gameData.electricity_lv == 6 || Data.Instance.gameData.electricity_lv == 0))
            {
                Debug.Log("��ų ī��Ʈ�� �� ��á�µ� ���� ��ų�� ��� ���� 6�� ���");
                gameObject.SetActive(false);
                return;
            }
            else
            {
                if (Data.Instance.gameData.tornado_lv == 6 || Data.Instance.gameData.tornado_lv == 0)//���� 6���̰ų� 0�� ��
                {
                    if (Data.Instance.gameData.voltTackle_lv == 6 || Data.Instance.gameData.voltTackle_lv == 0)
                    {
                        ran_num = 2;
                        Debug.Log("3��° ��ų�� �����Ǿ�� ��");
                    }
                    else if (Data.Instance.gameData.electricity_lv == 6 || Data.Instance.gameData.electricity_lv == 0)
                    {
                        ran_num = 1;
                        Debug.Log("2��° ��ų�� �����Ǿ�� ��");
                    }
                    else
                    {
                        ran_num = Random.Range(1, 3);
                        Debug.Log("2,3 �� �ϳ��� �����Ǿ�� ��");
                    }
                }
                else if (Data.Instance.gameData.voltTackle_lv == 6 || Data.Instance.gameData.voltTackle_lv == 0)
                {
                    if (Data.Instance.gameData.tornado_lv == 6 || Data.Instance.gameData.tornado_lv == 0)
                    {
                        ran_num = 2;
                        Debug.Log("3��° ��ų�� �����Ǿ�� ��");
                    }
                    else if (Data.Instance.gameData.electricity_lv == 6 || Data.Instance.gameData.electricity_lv == 0)
                    {
                        ran_num = 0;
                        Debug.Log("1��° ��ų�� �����Ǿ�� ��");
                    }
                    else
                    {
                        ran_num = Random.Range(0, 2);
                        if (ran_num == 1)
                            ran_num = 2;
                        Debug.Log("1,3 �� �ϳ��� �����Ǿ�� ��");
                    }
                }
                else if (Data.Instance.gameData.electricity_lv == 6 || Data.Instance.gameData.electricity_lv == 0)
                {
                    if (Data.Instance.gameData.tornado_lv == 6 || Data.Instance.gameData.tornado_lv == 0)
                    {
                        ran_num = 1;
                        Debug.Log("2��° ��ų�� �����Ǿ�� ��");
                    }
                    else if (Data.Instance.gameData.voltTackle_lv == 6 || Data.Instance.gameData.voltTackle_lv == 0)
                    {
                        ran_num = 0;
                        Debug.Log("1��° ��ų�� �����Ǿ�� ��");
                    }
                    else
                    {
                        ran_num = Random.Range(0, 2);
                        Debug.Log("1,2 �� �ϳ��� �����Ǿ�� ��");
                    }
                }
                else
                {
                    ran_num = Random.Range(0, 3);
                    Debug.Log("��ų ī��Ʈ�� �� ��á�� �� �� ��ΰ� ���� 6�� �ƴ� ���");
                }
            }
        }
        else//��ųī��Ʈ�� �� ��á�� ��
        {
            if (Data.Instance.gameData.tornado_lv == 6 && Data.Instance.gameData.voltTackle_lv == 6 && Data.Instance.gameData.electricity_lv == 6)
            {
                Debug.Log("��ų ī��Ʈ�� �� ��á�µ� ���� ��ų�� ��� ���� 6�� ���");
                gameObject.SetActive(false);
                return;
            }
            else
            {
                if (Data.Instance.gameData.tornado_lv == 6)
                {
                    if (Data.Instance.gameData.voltTackle_lv == 6)
                    {
                        ran_num = 2;
                        Debug.Log("3��° ��ų�� �����Ǿ�� ��");
                    }
                    else if (Data.Instance.gameData.electricity_lv == 6)
                    {
                        ran_num = 1;
                        Debug.Log("2��° ��ų�� �����Ǿ�� ��");
                    }
                    else
                    {
                        ran_num = Random.Range(1, 3);
                        Debug.Log("2,3 �� �ϳ��� �����Ǿ�� ��");
                    }
                }
                else if (Data.Instance.gameData.voltTackle_lv == 6)
                {
                    if (Data.Instance.gameData.tornado_lv == 6)
                    {
                        ran_num = 2;
                        Debug.Log("3��° ��ų�� �����Ǿ�� ��");
                    }
                    else if (Data.Instance.gameData.electricity_lv == 6)
                    {
                        ran_num = 0;
                        Debug.Log("1��° ��ų�� �����Ǿ�� ��");
                    }
                    else
                    {
                        ran_num = Random.Range(0, 2);
                        if (ran_num == 1)
                            ran_num = 2;
                        Debug.Log("1,3 �� �ϳ��� �����Ǿ�� ��");
                    }
                }
                else if (Data.Instance.gameData.electricity_lv == 6)
                {
                    if (Data.Instance.gameData.tornado_lv == 6)
                    {
                        ran_num = 1;
                        Debug.Log("2��° ��ų�� �����Ǿ�� ��");
                    }
                    else if (Data.Instance.gameData.voltTackle_lv == 6)
                    {
                        ran_num = 0;
                        Debug.Log("1��° ��ų�� �����Ǿ�� ��");
                    }
                    else
                    {
                        ran_num = Random.Range(0, 2);
                        Debug.Log("1,2 �� �ϳ��� �����Ǿ�� ��");
                    }
                }
                else
                {
                    ran_num = Random.Range(0, 3);
                    Debug.Log("��ų ī��Ʈ�� �� ��á�� �� �� ��ΰ� ���� 6�� �ƴ� ���");
                }
            }
        }
        Time.timeScale = 0;
        close_page.gameObject.SetActive(false);
        for (int i = 0; i < 3; i++)
        {
            result_obj[i].gameObject.SetActive(false);
            result_text[i].gameObject.SetActive(false);
        }
        StartCoroutine(Start_Slot());
    }

    IEnumerator Start_Slot()
    {
        if (ran_num == 0)
        {
            result_obj[0].gameObject.SetActive(true);
            result_text[0].gameObject.SetActive(true);
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
            result_text[1].gameObject.SetActive(true);
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
            result_text[2].gameObject.SetActive(true);
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
                if (Data.Instance.gameData.tornado_lv == 0)
                {
                    Manager.manager.pasuse_skill[Data.Instance.gameData.skill_cnt - 1].skill_Array[9].gameObject.SetActive(true);
                    Manager.manager.pasuse_skill[Data.Instance.gameData.skill_cnt - 1].skill_lv[0].gameObject.SetActive(true);
                    tornado_num = Data.Instance.gameData.skill_cnt - 1;
                    Data.Instance.gameData.skill_cnt++;
                }
                Data.Instance.gameData.tornado_lv++;
                if (Data.Instance.gameData.tornado_lv == 2)
                {
                    Manager.manager.objectManager.tornado_CT = 9f;
                    Manager.manager.pasuse_skill[tornado_num].skill_lv[1].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.tornado_lv == 3)
                {
                    Manager.manager.objectManager.tornado_CT = 8f;
                    Manager.manager.pasuse_skill[tornado_num].skill_lv[2].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.tornado_lv == 4)
                {
                    Manager.manager.objectManager.tornado_CT = 7f;
                    Manager.manager.pasuse_skill[tornado_num].skill_lv[3].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.tornado_lv == 5)
                {
                    Manager.manager.objectManager.tornado_CT = 5f;
                    Manager.manager.pasuse_skill[tornado_num].skill_lv[4].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.tornado_lv == 6)
                {
                    Manager.manager.objectManager.tornado_CT = 3f;
                    Manager.manager.pasuse_skill[tornado_num].skill_lv[5].gameObject.SetActive(true);
                }
            }
        }
        if (result_obj[1].gameObject.activeSelf == true)
        {
            if (Data.Instance.gameData.voltTackle_lv < 6)
            {
                if (Data.Instance.gameData.voltTackle_lv == 0)
                {
                    Manager.manager.pasuse_skill[Data.Instance.gameData.skill_cnt - 1].skill_Array[10].gameObject.SetActive(true);
                    Manager.manager.pasuse_skill[Data.Instance.gameData.skill_cnt - 1].skill_lv[0].gameObject.SetActive(true);
                    volttackle_num = Data.Instance.gameData.skill_cnt - 1;
                    Data.Instance.gameData.skill_cnt++;
                }
                Data.Instance.gameData.voltTackle_lv++;
                if (Data.Instance.gameData.voltTackle_lv == 2)
                {
                    Manager.manager.player.volttackle_CT = 21f;
                    Manager.manager.pasuse_skill[volttackle_num].skill_lv[1].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.voltTackle_lv == 3)
                {
                    Manager.manager.player.volttackle_CT = 18f;
                    Manager.manager.pasuse_skill[volttackle_num].skill_lv[2].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.voltTackle_lv == 4)
                {
                    Manager.manager.player.volttackle_CT = 15f;
                    Manager.manager.pasuse_skill[volttackle_num].skill_lv[3].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.voltTackle_lv == 5)
                {
                    Manager.manager.player.volttackle_CT = 13f;
                    Manager.manager.pasuse_skill[volttackle_num].skill_lv[4].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.voltTackle_lv == 6)
                {
                    Manager.manager.player.volttackle_CT = 10f;
                    Manager.manager.pasuse_skill[volttackle_num].skill_lv[5].gameObject.SetActive(true);
                }
            }
        }
        if (result_obj[2].gameObject.activeSelf == true)
        {
            if (Data.Instance.gameData.electricity_lv < 6)
            {
                if (Data.Instance.gameData.electricity_lv == 0)
                {
                    Manager.manager.pasuse_skill[Data.Instance.gameData.skill_cnt - 1].skill_Array[11].gameObject.SetActive(true);
                    Manager.manager.pasuse_skill[Data.Instance.gameData.skill_cnt - 1].skill_lv[0].gameObject.SetActive(true);
                    electricity_num = Data.Instance.gameData.skill_cnt - 1;
                    Data.Instance.gameData.skill_cnt++;
                }
                Data.Instance.gameData.electricity_lv++;
                if (Data.Instance.gameData.electricity_lv == 2)
                {
                    Manager.manager.objectManager.electricity_CT = 10f;
                    Manager.manager.pasuse_skill[electricity_num].skill_lv[1].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.electricity_lv == 3)
                {
                    Manager.manager.objectManager.electricity_CT = 8f;
                    Manager.manager.pasuse_skill[electricity_num].skill_lv[2].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.electricity_lv == 4)
                {
                    Manager.manager.objectManager.electricity_CT = 8f;
                    Manager.manager.pasuse_skill[electricity_num].skill_lv[3].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.electricity_lv == 5)
                {
                    Manager.manager.objectManager.electricity_CT = 5f;
                    Manager.manager.pasuse_skill[electricity_num].skill_lv[4].gameObject.SetActive(true);
                }
                else if (Data.Instance.gameData.electricity_lv == 6)
                {
                    Manager.manager.objectManager.electricity_CT = 3f;
                    Manager.manager.pasuse_skill[electricity_num].skill_lv[5].gameObject.SetActive(true);
                }
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
