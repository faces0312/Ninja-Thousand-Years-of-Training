using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using System;

public class AdmobManager : MonoBehaviour
{
    public bool is_Test;

    void Awake()
    {
        LoadFrontAd();

        LoadFrontAd2();
    }
    private void Start()
    {
        frontAd.OnAdClosed += HandleOnAdClosed;

        frontAd2.OnAdClosed += HandleOnAdClosed2;
    }


    const string frontTestID = "ca-app-pub-3940256099942544/8691691433";
    const string frontID = "ca-app-pub-7537224848353526/5338042228";

    const string front2ID = "ca-app-pub-7537224848353526/1224371544";



    InterstitialAd frontAd;

    InterstitialAd frontAd2;

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Data.Instance.gameData.money += (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score);

        if (Data.Instance.gameData.best_score < (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score))
            Data.Instance.gameData.best_score = (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score);

        Data.Instance.SaveGameData();

        SceneManager.LoadScene("MainScene");
    }

    public void HandleOnAdClosed2(object sender, EventArgs args)
    {
        Manager.manager.player.hp = Manager.manager.player.hp_max;
        Manager.manager.respawn_Page.gameObject.SetActive(false);
        Manager.manager.life_cnt--;
        Time.timeScale = 1;
    }

    AdRequest GetAdRequest()
    {
        return new AdRequest.Builder().Build();
    }


    void LoadFrontAd()
    {
        frontAd = new InterstitialAd(is_Test ? frontTestID : frontID);
        frontAd.LoadAd(GetAdRequest());
        frontAd.OnAdClosed += (sender, e) =>
        {
        };
    }

    void LoadFrontAd2()
    {
        frontAd2 = new InterstitialAd(is_Test ? frontTestID : front2ID);
        frontAd2.LoadAd(GetAdRequest());
        frontAd2.OnAdClosed += (sender, e) =>
        {
        };
    }

    public void ShowFrontAd()
    {
        frontAd.Show();

        //LoadFrontAd();
    }

    public void ShowFrontAd2()
    {
        frontAd2.Show();

        //LoadFrontAd();
    }
}
