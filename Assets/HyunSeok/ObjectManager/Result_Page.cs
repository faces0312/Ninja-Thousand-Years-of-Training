using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Result_Page : MonoBehaviour
{
    public AdmobManager ad;

    public Button result_page;//홈으로 돌아가기 위한 버튼

    public GameObject time;
    public GameObject mob;
    public GameObject boss;
    public GameObject score;
    public GameObject money;

    public TextMeshProUGUI time_text;
    public TextMeshProUGUI mob_text;
    public TextMeshProUGUI boss_text;
    public TextMeshProUGUI socre_text;
    public TextMeshProUGUI money_text;

    public GameObject result_skip;

    // Start is called before the first frame update
    void OnEnable()
    {
        result_page.interactable = false;
        result_skip.gameObject.SetActive(true);

        time_text.text = Manager.manager.time_text.text;
        mob_text.text = Data.Instance.gameData.mob_cnt.ToString();
        boss_text.text = Data.Instance.gameData.boss_cnt.ToString();

        time.gameObject.SetActive(false);
        mob.gameObject.SetActive(false);
        boss.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
        money.gameObject.SetActive(false);

        StartCoroutine(nameof(Time_Text));
    }

    IEnumerator Time_Text()
    {
        time.gameObject.SetActive(true);
        float scale = 2f;

        for (int i = 0; i < 10; i++)
        {
            time.gameObject.transform.localScale = new Vector3(scale, scale);
            scale -= 0.1f;
            yield return new WaitForSecondsRealtime(0.001f);
        }
        yield return new WaitForSecondsRealtime(0.3f);
        StartCoroutine(nameof(Mob_Text));
    }

    IEnumerator Mob_Text()
    {
        mob.gameObject.SetActive(true);
        float scale = 2f;
        for (int i = 0; i < 10; i++)
        {
            mob.gameObject.transform.localScale = new Vector3(scale, scale);
            scale -= 0.1f;
            yield return new WaitForSecondsRealtime(0.001f);
        }
        yield return new WaitForSecondsRealtime(0.3f);
        StartCoroutine(nameof(Boss_Text));
    }

    IEnumerator Boss_Text()
    {
        boss.gameObject.SetActive(true);
        float scale = 2f;
        for (int i = 0; i < 10; i++)
        {
            boss.gameObject.transform.localScale = new Vector3(scale, scale);
            scale -= 0.1f;
            yield return new WaitForSecondsRealtime(0.001f);
        }
        yield return new WaitForSecondsRealtime(0.3f);
        StartCoroutine(nameof(Score_Text));
        StartCoroutine(nameof(Money_Text));
    }

    IEnumerator Score_Text()
    {
        score.gameObject.SetActive(true);
        for(int i=0; i< (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score); i+=4)
        {
            socre_text.text = i.ToString();
            yield return new WaitForSecondsRealtime(0.0005f);
        }
        socre_text.text = (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score).ToString();
    }

    IEnumerator Money_Text()
    {
        money.gameObject.SetActive(true);
        for (int i = 0; i < (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score); i+=4)
        {
            money_text.text = i.ToString();
            yield return new WaitForSecondsRealtime(0.0005f);
        }
        money_text.text = (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score).ToString();
        
        result_page.interactable = true;
    }

    public void Go_Home()
    {
        Data.Instance.gameData.play_cnt++;
        if(Data.Instance.gameData.play_cnt % 3 == 0)
        {
            ad.ShowFrontAd();
        }
        else
        {
            Data.Instance.gameData.money += (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score);

            if (Data.Instance.gameData.best_score < (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score))
                Data.Instance.gameData.best_score = (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score);

            Data.Instance.SaveGameData();

            SceneManager.LoadScene("MainScene");
        }
    }

    public void Skip_Reusult()
    {
        StopCoroutine(nameof(Time_Text));
        StopCoroutine(nameof(Mob_Text));
        StopCoroutine(nameof(Boss_Text));
        StopCoroutine(nameof(Score_Text));
        StopCoroutine(nameof(Money_Text));

        time.gameObject.SetActive(true);
        mob.gameObject.SetActive(true);
        boss.gameObject.SetActive(true);
        score.gameObject.SetActive(true);
        money.gameObject.SetActive(true);

        float scale = 1f;
        time.gameObject.transform.localScale = new Vector3(scale, scale);
        mob.gameObject.transform.localScale = new Vector3(scale, scale);
        boss.gameObject.transform.localScale = new Vector3(scale, scale);
        socre_text.text = (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score).ToString();
        money_text.text = (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score).ToString();

        result_skip.gameObject.SetActive(false);
        StartCoroutine(nameof(Go_Home_Button_ActiveSelf));
    }

    IEnumerator Go_Home_Button_ActiveSelf()
    {
        yield return new WaitForSecondsRealtime(0.3f);
        result_page.interactable = true;
    }
}
