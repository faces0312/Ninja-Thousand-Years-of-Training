using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Camera camera;

    public static Manager manager;
    public ObjectManager objectManager;
    public Player player;

    public Slot_Normal slot_Normal;
    public Slot_Fire slot_Fire;
    public Slot_Wood slot_Wood;
    public Slot_Mecha slot_Mecha;
    //public Mob1 mob;  //�ǵ�

    public GameObject left_bounce;
    public GameObject right_bounce;
    public GameObject up_bounce;
    public GameObject down_bounce;

    public int lv;//난이도(몹 수와 연관됨)
    private float time_bigWave;//빅웨이브 등장 시간
    private float time_mob_hp;//몹 체력 증가 시간

    /*public float exp_Tmp;
    public Slider exp_Bar;*/

    private int time_min;
    private float time_sec;
    public TextMeshProUGUI time_text;

    public GameObject pause_page;
    [Serializable]
    public class Skill_Array
    {
        public GameObject[] skill_Array;//스킬종류(12개)
    }
    public Skill_Array[] pasuse_skill;//pause에있는 스킬 칸수 (5개)


    private void Awake()
    {
        //Screen.SetResolution(640, 360, true);
        Application.targetFrameRate = 30;
        manager = this;

        camera.orthographicSize = 5f;
        lv = 0;

        Data.Instance.gameData.skill_cnt = 1;
        Data.Instance.gameData.player_hp = 100;

        Data.Instance.gameData.drop_percent = 10;
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

        Data.Instance.gameData.mob1_hp = 1;
        Data.Instance.gameData.bat_hp = 1;
        Data.Instance.gameData.gatekeeper_hp = 1;
        Data.Instance.gameData.golem_hp = 3;

        Data.Instance.gameData.boss_hp = 1000;

        Data.Instance.gameData.mob1_dmg = 1;
        Data.Instance.gameData.bat_body_dmg = 1;
        Data.Instance.gameData.bat_atk_dmg = 2;
        Data.Instance.gameData.gatekeeper_dmg= 1;
        Data.Instance.gameData.golem_dmg = 2;

        Data.Instance.gameData.bat_boss_body = 0;
        Data.Instance.gameData.bat_boss_atk = 2;
        Data.Instance.gameData.bat_boss_laser = 4;

        Data.Instance.gameData.golem_boss_body = 0;
        Data.Instance.gameData.golem_boss_lighting = 3;
        Data.Instance.gameData.golem_boss_wire = 0;
        Data.Instance.gameData.golem_boss_laser = 4;

        Data.Instance.gameData.redspit_boss_body = 0;
        Data.Instance.gameData.redspit_boss_atk = 2;

        Data.Instance.gameData.mob_cnt = 0;
        /*
        Data.Instance.gameData.exp = 0;
        exp_Tmp = 100;*/
        time_bigWave = 0;
        time_mob_hp = 0;
        time_min = 0;
        time_sec = 0f;
        //Invoke("Exp_Practice",1f);

        //StartCoroutine(Player_Location());
    }

    private void Start()
    {
        pause_page.gameObject.SetActive(false);
    }
    private void Update()
    {
        //시간 측정
        time_sec += Time.deltaTime;
        if ((int)time_sec > 59)
        {
            time_sec = 0;
            time_min++;
        }
        time_text.text = string.Format("{0:D2} : {1:D2}", time_min, (int)time_sec);

        //빅 웨이브 쿨타임
        time_bigWave += Time.deltaTime;
        if((int)time_bigWave >= 59)
        {
            if(objectManager.is_bigwave == true)
            {
                time_bigWave = 0;
                lv++;
                StartCoroutine(Camera_Up());
            }
        }

        //몹 체력 증가 쿨타임
        time_mob_hp += Time.deltaTime;
        if((int)time_mob_hp > 19)
        {
            time_mob_hp = 0;
            Data.Instance.gameData.mob1_hp += 2;
            Data.Instance.gameData.bat_hp += 2;
            Data.Instance.gameData.gatekeeper_hp += 2;
            Data.Instance.gameData.golem_hp += 3;
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
            yield return new WaitForSeconds(3f);
        }

        yield return new WaitForSeconds(10f);
        StartCoroutine(Camera_Down());
    }

    IEnumerator Camera_Up()
    {
        for (int i = 0; i < 200; i++)
        {
            camera.orthographicSize += 0.01f;
            left_bounce.transform.position = new Vector3(left_bounce.transform.position.x - 0.007f, left_bounce.transform.position.y);
            right_bounce.transform.position = new Vector3(right_bounce.transform.position.x + 0.007f, right_bounce.transform.position.y);
            up_bounce.transform.position = new Vector3(up_bounce.transform.position.x , up_bounce.transform.position.y + 0.01f);
            down_bounce.transform.position = new Vector3(down_bounce.transform.position.x, down_bounce.transform.position.y - 0.01f);

            yield return new WaitForSeconds(0.01f);
        }
        camera.orthographicSize = 7f;
        StartCoroutine(BigWave());
    }

    IEnumerator Camera_Down()
    {
        for (int i = 0; i < 200; i++)
        {
            camera.orthographicSize -= 0.01f;
            left_bounce.transform.position = new Vector3(left_bounce.transform.position.x + 0.007f, left_bounce.transform.position.y);
            right_bounce.transform.position = new Vector3(right_bounce.transform.position.x - 0.007f, right_bounce.transform.position.y);
            up_bounce.transform.position = new Vector3(up_bounce.transform.position.x, up_bounce.transform.position.y - 0.01f);
            down_bounce.transform.position = new Vector3(down_bounce.transform.position.x, down_bounce.transform.position.y + 0.01f);

            yield return new WaitForSeconds(0.01f);
        }
        camera.orthographicSize = 5f;
    }

    /*IEnumerator Player_Location()
    {
        Data.Instance.gameData.player_Location = player.gameObject.transform.position;
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(Player_Location());
    }*/

    public void Pause()
    {
        pause_page.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Pause_End()
    {
        pause_page.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Go_Main()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }
}
