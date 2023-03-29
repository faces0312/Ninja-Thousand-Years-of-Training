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
    }
    private void Start()
    {
        frontAd.OnAdClosed += HandleOnAdClosed;
    }


    const string frontTestID = "ca-app-pub-3940256099942544/8691691433";
    const string frontID = "ca-app-pub-7537224848353526/5338042228";



    InterstitialAd frontAd;

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Data.Instance.gameData.money += (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score);

        if (Data.Instance.gameData.best_score < (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score))
            Data.Instance.gameData.best_score = (Data.Instance.gameData.boss_cnt * 500 + Data.Instance.gameData.mob_cnt * 3 + (int)Manager.manager.time_score);

        Data.Instance.SaveGameData();

        SceneManager.LoadScene("MainScene");
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

    public void ShowFrontAd()
    {
        frontAd.Show();

        //LoadFrontAd();
    }
}
