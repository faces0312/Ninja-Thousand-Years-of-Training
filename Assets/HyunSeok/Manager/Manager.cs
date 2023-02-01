using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public static Manager manager;
    public ObjectManager objectManager;
    public Player player;
    //public Mob1 mob;  //�ǵ�

    public int lv;
    private float time_bigWave;
    /*public float exp_Tmp;
    public Slider exp_Bar;*/

    private int time_min;
    private float time_sec;
    public TextMeshProUGUI time_text;
    private void Awake()
    {
        manager = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        lv = 0;

        Data.Instance.gameData.normal_atk_lv = 1;
        Data.Instance.gameData.shadow_partner_lv = 0;
        Data.Instance.gameData.fire_lv = 0;
        Data.Instance.gameData.wind_lv = 0;
        Data.Instance.gameData.talisman_lv = 0;
        Data.Instance.gameData.fire_column_lv = 0;
        Data.Instance.gameData.voltTackle_lv = 0;
        Data.Instance.gameData.tornado_lv = 0;
        Data.Instance.gameData.tree_lv = 0;
        Data.Instance.gameData.boomerang_lv = 0;
        Data.Instance.gameData.electricity_lv = 0;
        Data.Instance.gameData.windwall_lv = 0;

        Data.Instance.gameData.mob1_hp = 5;
        Data.Instance.gameData.bat_normal_hp = 5;
        Data.Instance.gameData.bat_fire_hp = 5;
        Data.Instance.gameData.bat_wood_hp = 5;
        Data.Instance.gameData.bat_mecha_hp = 5;
        /*
        Data.Instance.gameData.exp = 0;
        exp_Tmp = 100;*/
        time_bigWave = 0;
        time_min = 0;
        time_sec = 0f;
        //Invoke("Exp_Practice",1f);
    }

    private void Update()
    {
        time_sec += Time.deltaTime;
        if ((int)time_sec > 59)
        {
            time_sec = 0;
            time_min++;
        }
        time_text.text = string.Format("{0:D2} : {1:D2}", time_min, (int)time_sec);

        time_bigWave += Time.deltaTime;
        if((int)time_bigWave >= 10)
        {
            time_bigWave = 0;
            lv++;
            StartCoroutine(BigWave());

        }
        /*exp_Bar.value = Data.Instance.gameData.exp / exp_Tmp;

        if(Data.Instance.gameData.exp >= exp_Tmp)
        {
            Data.Instance.gameData.exp -= exp_Tmp;
            exp_Tmp *= 2;
            lv++;
        }*/
    }

    /*public void Exp_Practice()
    {
        Data.Instance.gameData.exp += 10;
        Invoke("Exp_Practice", 1f);
<<<<<d<< HEAD
    }*/
    IEnumerator BigWave()
    {
        for (int i = 0; i < lv; i++)
        {
            objectManager.Mob_BigWave_General();
            yield return new WaitForSeconds(1f);
        }
    }
}
