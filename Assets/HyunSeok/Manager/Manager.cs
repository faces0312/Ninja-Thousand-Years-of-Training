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
    public float time_bigWave;//빅웨이브 등장 시간

    /*public float exp_Tmp;
    public Slider exp_Bar;*/
    public float time_score;
    private int time_min;
    private float time_sec;
    public TextMeshProUGUI time_text;

    public GameObject pause_page;
    
    public GameObject result_page;
    public GameObject result;

    //맵 이름 관련
    public bool is_fire_name;
    public bool is_wood_name;
    public bool is_mecha_name;
    public GameObject map_name;
    public GameObject normal_map_name;
    public GameObject normal_map_name_image;
    public GameObject normal_map_name_text;
    public GameObject fire_map_name;
    public GameObject fire_map_name_image;
    public GameObject fire_map_name_text;
    public GameObject wood_map_name;
    public GameObject wood_map_name_image;
    public GameObject wood_map_name_text;
    public GameObject mecha_map_name;
    public GameObject mecha_map_name_image;
    public GameObject mecha_map_name_text;
    public GameObject map_name_left;
    public GameObject map_name_right;

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

        Data.Instance.gameData.boss_hp = 300;

        Data.Instance.gameData.mob1_dmg = 1;
        Data.Instance.gameData.bat_body_dmg = 1;
        Data.Instance.gameData.bat_atk_dmg = 3;
        Data.Instance.gameData.gatekeeper_dmg= 1;
        Data.Instance.gameData.golem_dmg = 1;

        Data.Instance.gameData.bat_boss_body = 1;
        Data.Instance.gameData.bat_boss_atk = 3;
        Data.Instance.gameData.bat_boss_laser = 10;

        Data.Instance.gameData.golem_boss_body = 1;
        Data.Instance.gameData.golem_boss_lighting = 15;
        Data.Instance.gameData.golem_boss_wire = 3;
        Data.Instance.gameData.golem_boss_laser = 10;

        Data.Instance.gameData.redspit_boss_body = 1;
        Data.Instance.gameData.redspit_boss_atk = 3;

        Data.Instance.gameData.score = 0;
        Data.Instance.gameData.boss_cnt = 0;
        Data.Instance.gameData.mob_cnt = 0;
        /*
        Data.Instance.gameData.exp = 0;
        exp_Tmp = 100;*/
        time_bigWave = 0;
        time_min = 0;
        time_sec = 0f;
        //Invoke("Exp_Practice",1f);

        //StartCoroutine(Player_Location());
        is_fire_name = false;
        is_wood_name = false;
        is_mecha_name = false;
    }

    private void Start()
    {
        result.gameObject.SetActive(false);
        result_page.gameObject.SetActive(false);
        pause_page.gameObject.SetActive(false);
        map_name.gameObject.SetActive(false);

        StartCoroutine(Normal_Name());
    }
    private void Update()
    {
        //시간 측정
        time_score += Time.deltaTime;//점수 및 돈 시간

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
    IEnumerator Normal_Name()
    {
        map_name.gameObject.SetActive(true);
        normal_map_name.gameObject.SetActive(true);
        normal_map_name_image.gameObject.SetActive(true);
        normal_map_name_text.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(true);
        map_name_right.gameObject.SetActive(true);

        normal_map_name_image.gameObject.transform.localScale = new Vector3(1, 1);
        map_name_left.gameObject.transform.localPosition = new Vector3(-50, 680);
        map_name_right.gameObject.transform.localPosition = new Vector3(50, 680);
        for (int i=0;i<30;i++)
        {
            if (i == 10)
                normal_map_name_text.gameObject.SetActive(true);

            normal_map_name_image.gameObject.transform.localScale = new Vector3(i/2, normal_map_name_image.gameObject.transform.localScale.y);
            map_name_left.gameObject.transform.localPosition = new Vector3(-50 - i * 14f, map_name_left.gameObject.transform.localPosition.y);
            map_name_right.gameObject.transform.localPosition = new Vector3(50 + i * 14f, map_name_right.gameObject.transform.localPosition.y);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        normal_map_name.gameObject.SetActive(false);
        normal_map_name_image.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(false);
        map_name_right.gameObject.SetActive(false);
        map_name.gameObject.SetActive(false);
    }

    public void Go_Fire_Name()
    {
        StartCoroutine(Fire_Name());
    }
    IEnumerator Fire_Name()
    {
        map_name.gameObject.SetActive(true);
        fire_map_name.gameObject.SetActive(true);
        fire_map_name_image.gameObject.SetActive(true);
        fire_map_name_text.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(true);
        map_name_right.gameObject.SetActive(true);

        fire_map_name_image.gameObject.transform.localScale = new Vector3(1, 1);
        map_name_left.gameObject.transform.localPosition = new Vector3(-50, 680);
        map_name_right.gameObject.transform.localPosition = new Vector3(50, 680);
        for (int i = 0; i < 30; i++)
        {
            if (i == 10)
                fire_map_name_text.gameObject.SetActive(true);

            fire_map_name_image.gameObject.transform.localScale = new Vector3(i / 2, fire_map_name_image.gameObject.transform.localScale.y);
            map_name_left.gameObject.transform.localPosition = new Vector3(-50 - i * 14f, map_name_left.gameObject.transform.localPosition.y);
            map_name_right.gameObject.transform.localPosition = new Vector3(50 + i * 14f, map_name_right.gameObject.transform.localPosition.y);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        fire_map_name.gameObject.SetActive(false);
        fire_map_name_image.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(false);
        map_name_right.gameObject.SetActive(false);
        map_name.gameObject.SetActive(false);
    }
    public void Go_Wood_Name()
    {
        StartCoroutine(Wood_Name());
    }
    IEnumerator Wood_Name()
    {
        map_name.gameObject.SetActive(true);
        wood_map_name.gameObject.SetActive(true);
        wood_map_name_image.gameObject.SetActive(true);
        wood_map_name_text.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(true);
        map_name_right.gameObject.SetActive(true);

        wood_map_name_image.gameObject.transform.localScale = new Vector3(1, 1);
        map_name_left.gameObject.transform.localPosition = new Vector3(-50, 680);
        map_name_right.gameObject.transform.localPosition = new Vector3(50, 680);
        for (int i = 0; i < 30; i++)
        {
            if (i == 10)
                wood_map_name_text.gameObject.SetActive(true);

            wood_map_name_image.gameObject.transform.localScale = new Vector3(i / 2, wood_map_name_image.gameObject.transform.localScale.y);
            map_name_left.gameObject.transform.localPosition = new Vector3(-50 - i * 14f, map_name_left.gameObject.transform.localPosition.y);
            map_name_right.gameObject.transform.localPosition = new Vector3(50 + i * 14f, map_name_right.gameObject.transform.localPosition.y);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        wood_map_name.gameObject.SetActive(false);
        wood_map_name_image.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(false);
        map_name_right.gameObject.SetActive(false);
        map_name.gameObject.SetActive(false);
    }
    public void Go_Mecha_Name()
    {
        StartCoroutine(Mecha_Name());
    }
    IEnumerator Mecha_Name()
    {
        map_name.gameObject.SetActive(true);
        mecha_map_name.gameObject.SetActive(true);
        mecha_map_name_image.gameObject.SetActive(true);
        mecha_map_name_text.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(true);
        map_name_right.gameObject.SetActive(true);

        mecha_map_name_image.gameObject.transform.localScale = new Vector3(1, 1);
        map_name_left.gameObject.transform.localPosition = new Vector3(-50, 680);
        map_name_right.gameObject.transform.localPosition = new Vector3(50, 680);
        for (int i = 0; i < 30; i++)
        {
            if (i == 10)
                mecha_map_name_text.gameObject.SetActive(true);

            mecha_map_name_image.gameObject.transform.localScale = new Vector3(i / 2, mecha_map_name_image.gameObject.transform.localScale.y);
            map_name_left.gameObject.transform.localPosition = new Vector3(-50 - i * 14f, map_name_left.gameObject.transform.localPosition.y);
            map_name_right.gameObject.transform.localPosition = new Vector3(50 + i * 14f, map_name_right.gameObject.transform.localPosition.y);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        mecha_map_name.gameObject.SetActive(false);
        mecha_map_name_image.gameObject.SetActive(false);
        map_name_left.gameObject.SetActive(false);
        map_name_right.gameObject.SetActive(false);
        map_name.gameObject.SetActive(false);
    }
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
