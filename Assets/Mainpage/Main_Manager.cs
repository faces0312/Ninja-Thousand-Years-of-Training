using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Main_Manager : MonoBehaviour
{
    public TextMeshProUGUI money;

    //업그레이드페이지 관련
    public GameObject upgrade_page;
    public GameObject upgrade_normal_page;
    public GameObject upgrade_fire_page;
    public GameObject upgrade_wood_page;
    public GameObject upgrade_mecha_page;
    public GameObject complete_normal_page;
    public GameObject complete_fire_page;
    public GameObject complete_wood_page;
    public GameObject complete_mecha_page;
    public GameObject complete_normal;
    public GameObject complete_fire;
    public GameObject complete_wood;
    public GameObject complete_mecha;
    public TextMeshProUGUI normal_change;
    public TextMeshProUGUI fire_change;
    public TextMeshProUGUI wood_change;
    public TextMeshProUGUI mecha_change;
    public TextMeshProUGUI normal_money;
    public TextMeshProUGUI fire_money;
    public TextMeshProUGUI wood_money;
    public TextMeshProUGUI mecha_money;
    public Button normal_upgrade;
    public Button fire_upgrade;
    public Button wood_upgrade;
    public Button mecha_upgrade;
    public TextMeshProUGUI normal_lv;
    public TextMeshProUGUI fire_lv;
    public TextMeshProUGUI wood_lv;
    public TextMeshProUGUI mecha_lv;
    public TextMeshProUGUI normal_atk;
    public TextMeshProUGUI fire_atk;
    public TextMeshProUGUI wood_atk;
    public TextMeshProUGUI mecha_atk;

    private void Start()
    {
        upgrade_page.gameObject.SetActive(false);
        upgrade_normal_page.gameObject.SetActive(false);
        upgrade_fire_page.gameObject.SetActive(false);
        upgrade_wood_page.gameObject.SetActive(false);
        upgrade_mecha_page.gameObject.SetActive(false);
        complete_normal_page.gameObject.SetActive(false);
        complete_fire_page.gameObject.SetActive(false);
        complete_wood_page.gameObject.SetActive(false);
        complete_mecha_page.gameObject.SetActive(false);

        Data.Instance.gameData.player_normal_lv = 0;
        Data.Instance.gameData.player_fire_lv = 0;
        Data.Instance.gameData.player_wood_lv = 0;
        Data.Instance.gameData.player_mecha_lv = 0;

        Data.Instance.gameData.money = 3300;
    }
    public void Game_Start()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //업그레이드 관련ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    public void Upgrade_Page()
    {
        upgrade_page.gameObject.SetActive(true);
    }
    public void Normal_Upgrade_Page()
    {
        upgrade_normal_page.gameObject.SetActive(true);
    }
    public void Dis_Normal_Upgrade_Page()
    {
        upgrade_normal_page.gameObject.SetActive(false);
    }
    public void Fire_Upgrade_Page()
    {
        upgrade_fire_page.gameObject.SetActive(true);
    }
    public void Dis_Fire_Upgrade_Page()
    {
        upgrade_fire_page.gameObject.SetActive(false);
    }
    public void Wood_Upgrade_Page()
    {
        upgrade_wood_page.gameObject.SetActive(true);
    }
    public void Dis_Wood_Upgrade_Page()
    {
        upgrade_wood_page.gameObject.SetActive(false);
    }
    public void Mecha_Upgrade_Page()
    {
        upgrade_mecha_page.gameObject.SetActive(true);
    }
    public void Dis_Mecha_Upgrade_Page()
    {
        upgrade_mecha_page.gameObject.SetActive(false);
    }
    public void Normal_Upgrade()
    {
        complete_normal_page.gameObject.SetActive(true);
        StartCoroutine(Complete_Normal());
        Data.Instance.gameData.player_normal_lv++;
        Data.Instance.gameData.money -= (Data.Instance.gameData.player_normal_lv * 1000);
        Data.Instance.SaveGameData();
    }
    public void Fire_Upgrade()
    {
        complete_fire_page.gameObject.SetActive(true);
        StartCoroutine(Complete_Fire());
        Data.Instance.gameData.player_fire_lv++;
        Data.Instance.gameData.money -= (Data.Instance.gameData.player_fire_lv * 1000);
        Data.Instance.SaveGameData();
    }
    public void Wood_Upgrade()
    {
        complete_wood_page.gameObject.SetActive(true);
        StartCoroutine(Complete_Wood());
        Data.Instance.gameData.player_wood_lv++;
        Data.Instance.gameData.money -= (Data.Instance.gameData.player_wood_lv * 1000);
        Data.Instance.SaveGameData();
    }
    public void Mecha_Upgrade()
    {
        complete_mecha_page.gameObject.SetActive(true);
        StartCoroutine(Complete_Mecha());
        Data.Instance.gameData.player_mecha_lv++;
        Data.Instance.gameData.money -= (Data.Instance.gameData.player_mecha_lv * 1000);
        Data.Instance.SaveGameData();
    }
    public void Dis_Complete_Normal()
    {
        complete_normal_page.gameObject.SetActive(false);
    }
    public void Dis_Complete_Fire()
    {
        complete_fire_page.gameObject.SetActive(false);
    }
    public void Dis_Complete_Wood()
    {
        complete_wood_page.gameObject.SetActive(false);
    }
    public void Dis_Complete_Mecha()
    {
        complete_mecha_page.gameObject.SetActive(false);
    }
    public void Dis_Upgrade_Page()
    {
        upgrade_page.gameObject.SetActive(false);
    }
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

    private void Update()
    {
        money.text = Data.Instance.gameData.money.ToString();

        normal_lv.text = "Lv " + Data.Instance.gameData.player_normal_lv.ToString();
        fire_lv.text = "Lv " + Data.Instance.gameData.player_fire_lv.ToString();
        wood_lv.text = "Lv " + Data.Instance.gameData.player_wood_lv.ToString();
        mecha_lv.text = "Lv " + Data.Instance.gameData.player_mecha_lv.ToString();

        normal_atk.text = "데미지 +" + Data.Instance.gameData.player_normal_lv.ToString();
        fire_atk.text = "데미지 +" + Data.Instance.gameData.player_fire_lv.ToString();
        wood_atk.text = "데미지 +" + Data.Instance.gameData.player_wood_lv.ToString();
        mecha_atk.text = "데미지 +" + Data.Instance.gameData.player_mecha_lv.ToString();

        normal_change.text = "+" + Data.Instance.gameData.player_normal_lv.ToString() + " -> +" + (Data.Instance.gameData.player_normal_lv + 1).ToString();
        fire_change.text = "+" + Data.Instance.gameData.player_fire_lv.ToString() + " -> +" + (Data.Instance.gameData.player_fire_lv + 1).ToString();
        wood_change.text = "+" + Data.Instance.gameData.player_wood_lv.ToString() + " -> +" + (Data.Instance.gameData.player_wood_lv + 1).ToString();
        mecha_change.text = "+" + Data.Instance.gameData.player_mecha_lv.ToString() + " -> +" + (Data.Instance.gameData.player_mecha_lv + 1).ToString();

        normal_money.text = "비용 " + ((Data.Instance.gameData.player_normal_lv + 1) * 1000).ToString();
        fire_money.text = "비용 " + ((Data.Instance.gameData.player_fire_lv + 1) * 1000).ToString();
        wood_money.text = "비용 " + ((Data.Instance.gameData.player_wood_lv + 1) * 1000).ToString();
        mecha_money.text = "비용 " + ((Data.Instance.gameData.player_mecha_lv + 1) * 1000).ToString();

        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_normal_lv + 1) * 1000)
            normal_upgrade.interactable = false;
        else
            normal_upgrade.interactable = true;

        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_fire_lv + 1) * 1000)
            fire_upgrade.interactable = false;
        else
            fire_upgrade.interactable = true;

        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_wood_lv + 1) * 1000)
            wood_upgrade.interactable = false;
        else
            wood_upgrade.interactable = true;

        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_mecha_lv + 1) * 1000)
            mecha_upgrade.interactable = false;
        else
            mecha_upgrade.interactable = true;
    }

    IEnumerator Complete_Normal()
    {
        float scale = 0.5f;
        for(int i=0; i<10; i++)
        {
            complete_normal.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }

    IEnumerator Complete_Fire()
    {
        float scale = 0.5f;
        for (int i = 0; i < 10; i++)
        {
            complete_fire.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }

    IEnumerator Complete_Wood()
    {
        float scale = 0.5f;
        for (int i = 0; i < 10; i++)
        {
            complete_wood.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }

    IEnumerator Complete_Mecha()
    {
        float scale = 0.5f;
        for (int i = 0; i < 10; i++)
        {
            complete_mecha.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }
}
