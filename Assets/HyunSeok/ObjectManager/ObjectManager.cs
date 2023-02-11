using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public Manager manager;

    public ObjectPool objectPool;
    public Player player;
    public Player_Body player_Body;
    public ShadowPartner shadowPartner1;
    public ShadowPartner shadowPartner2;

    private string[] atk_str;
    private string[] mob_Normal_str;
    private string[] mob_Fire_str;
    private string[] mob_Wood_str;
    private string[] mob_Mecha_str;
    private string[] letter_str;

    GameObject mob1;
    public GameObject[] mob_Location;
    private float mob_CT;//몹 쿨타임
    private float mob_Tmp_CT;

    Mob closetEnemy;
    GameObject atk_normal;
    GameObject atk_shadow;
    GameObject frieColumn;
    GameObject wind;
    GameObject electricity;

    public bool is_atk;//(맵안에 몹이 있는 상태인지)

    //----------------전체 쿨타임
    public float atk_normal_CT;//표창 쿨타임
    public float shadow_partner_CT;//쉐도우 파트너 쿨타임
    public float fire_CT;
    public float talisman_CT;
    public float firecolumn_CT;
    public float tornado_CT;
    public float tree_CT;
    public float boomerang_CT;
    public float electricity_CT;
    public float windwall_CT;
    public float wind_CT;

    //-------------현재 시간 쿨타임
    private float atk_normal_Tmp_CT;
    private float shadow_partner_Tmp_CT;
    private float fire_Tmp_CT;
    private float talisman_Tmp_CT;
    private float firecolumn_Tmp_CT;
    public float tornado_Tmp_CT;
    private float tree_Tmp_CT;
    private float boomerang_Tmp_CT;
    private float electricity_Tmp_CT;
    private float windwall_Tmp_CT;
    private float wind_Tmp_CT;

    void Awake()
    {
        atk_str = new string[] { "Normal_Atk" , "Shadow_Atk" ,"Fire", "Talisman", "FireColumn", "Tornado", "Tree", "Boomerang", "Electricity" ,"WindWall", "Wind"};
        //몹마다 퍼센트 확률로 등장
        mob_Normal_str = new string[] { "Mob1", "Bat_Normal" };
        mob_Fire_str = new string[] { "Mob1", "Bat_Fire" };
        mob_Wood_str = new string[] { "Mob1", "Bat_Wood" };
        mob_Mecha_str = new string[] { "Mob1", "Bat_Mecha" };
        letter_str = new string[] { "Normal_Atk_Letter" , "Fire_Letter", "Wood_Letter", "Mecha_Letter" };
    }

    private void Start()
    {
        mob_CT = 1f;
        mob_Tmp_CT = mob_CT;

        atk_normal_CT = 0.5f;
        atk_normal_Tmp_CT = atk_normal_CT;

        shadow_partner_CT = 1f;
        shadow_partner_Tmp_CT = shadow_partner_CT;

        fire_CT = 7f;
        fire_Tmp_CT = fire_CT;

        talisman_CT = 18f;
        talisman_Tmp_CT = talisman_CT;

        firecolumn_CT = 10f;
        firecolumn_Tmp_CT = firecolumn_CT;

        tornado_CT = 10f;
        tornado_Tmp_CT = tornado_CT;

        boomerang_CT = 10f;
        boomerang_Tmp_CT = boomerang_CT;

        electricity_CT = 23f;  
        electricity_Tmp_CT = electricity_CT;

        wind_CT = 17f;
        wind_Tmp_CT = wind_CT;

        windwall_CT = 3f;
        windwall_Tmp_CT = windwall_CT;

        tree_CT = 70f;
        tree_Tmp_CT = tree_CT;

      

        for(int i=0; i<15; i++)
        {
            Mob_General();
        }
    }

    private void Update()
    {
        //몹 생성 쿨
        if (mob_Tmp_CT > 0)
            mob_Tmp_CT -= Time.deltaTime;
        else
        {
            if(manager.lv == 0)
            {
                for(int i=0; i<3; i++)
                    Mob_General();
            }
            else if (manager.lv == 1)
            {
                for (int i = 0; i < 4; i++)
                    Mob_General();
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    Mob_General();
            }
            mob_Tmp_CT = mob_CT;
        }


        if (is_atk == true)
        {
            if (atk_normal_Tmp_CT > 0)
                atk_normal_Tmp_CT -= Time.deltaTime;
            else
            {
                Normal_Atk_General();
                atk_normal_Tmp_CT = atk_normal_CT;
            }

            if (Data.Instance.gameData.shadow_partner_lv > 0)
            {
                if (shadow_partner_Tmp_CT > 0)
                    shadow_partner_Tmp_CT -= Time.deltaTime;
                else
                {
                    if (Data.Instance.gameData.shadow_partner_lv == 6)
                    {
                        ShadowPartner1_Atk_General();
                        ShadowPartner2_Atk_General();
                    }
                    else
                        ShadowPartner1_Atk_General();
                    shadow_partner_Tmp_CT = shadow_partner_CT;
                }
            }
        }


        if (Data.Instance.gameData.fire_lv > 0)
        {
            if (fire_Tmp_CT > 0)
                fire_Tmp_CT -= Time.deltaTime;
            else
            {
                if(Data.Instance.gameData.fire_lv == 1)
                {
                    Fire1_General();
                }
                else if (Data.Instance.gameData.fire_lv == 2)
                {
                    Fire1_General();
                }
                else if (Data.Instance.gameData.fire_lv == 3)
                {
                    Fire2_General();
                }
                else if (Data.Instance.gameData.fire_lv == 4)
                {
                    Fire4_General();
                }
                else if (Data.Instance.gameData.fire_lv == 5)
                {
                    Fire4_General();
                }
                else if (Data.Instance.gameData.fire_lv == 6)
                {
                    Fire12_General();
                }
                fire_Tmp_CT = fire_CT;
            }
        }

        if (Data.Instance.gameData.talisman_lv > 0)
        {
            if (talisman_Tmp_CT > 0)
                talisman_Tmp_CT -= Time.deltaTime;
            else
            {
                StartCoroutine("Talisman_General");
                talisman_Tmp_CT = talisman_CT;
            }
        }

        if(Data.Instance.gameData.fire_column_lv > 0)
        {
            if (firecolumn_Tmp_CT > 0)
                firecolumn_Tmp_CT -= Time.deltaTime;
            else
            {
                FireColumn_General();
                firecolumn_Tmp_CT = firecolumn_CT;
            }
        }

        if (Data.Instance.gameData.tornado_lv > 0)
        {
            if (tornado_Tmp_CT > 0)
                tornado_Tmp_CT -= Time.deltaTime;
            else
            {
                Tornado_General();
                tornado_Tmp_CT = tornado_CT;
            }
        }
        if (Data.Instance.gameData.tree_lv > 0)
        {
            if (tree_Tmp_CT > 0)
                tree_Tmp_CT -= Time.deltaTime;
            else
            { //
                Tree_General(); 
                tree_Tmp_CT = tree_CT;
            }
        }

        if (Data.Instance.gameData.boomerang_lv > 0)
        {
            if (boomerang_Tmp_CT > 0)
                boomerang_Tmp_CT -= Time.deltaTime;
            else
            { //
                Boomerang_General();
                boomerang_Tmp_CT = boomerang_CT;
            }
        }

        if (Data.Instance.gameData.electricity_lv > 0)
        { //생성쿨타임
            if (electricity_Tmp_CT > 0) //생성 쿨타임 1초줄어들어요
                electricity_Tmp_CT -= Time.deltaTime;
            else
            { 
                Electric_General(); //생성 
                electricity_Tmp_CT = electricity_CT; //
            }
        }

        if (Data.Instance.gameData.windwall_lv > 0)
        { //생성쿨타임히히
            if (windwall_Tmp_CT > 0) //생성 쿨타임 1초줄어들어요
                windwall_Tmp_CT -= Time.deltaTime;
            else
            {
                WindWall_General(); //생성 
                windwall_Tmp_CT = windwall_CT; //
            }
        }

        if (Data.Instance.gameData.wind_lv > 0)
        { //생성쿨타임히히
            if (wind_Tmp_CT > 0) //생성 쿨타임 1초줄어들어요
                wind_Tmp_CT -= Time.deltaTime;
            else
            {
                Wind_General(); //생성 
                wind_Tmp_CT = wind_CT; //
            }
        }
    }

    public void Mob_General()
    {
        int ran_mob;//몹 생성 랜덤값
        int ran_location;//몹 위치 랜덤값

        ran_mob = Random.Range(0, 2);
        ran_location = Random.Range(0, 28);

        if (player_Body.in_Normal == true)
        {
            mob1 = objectPool.MakeObj(mob_Normal_str[ran_mob]);
            mob1.transform.position = mob_Location[ran_location].transform.position;
        }
        else if (player_Body.in_Fire == true)
        {
            mob1 = objectPool.MakeObj(mob_Fire_str[ran_mob]);
            mob1.transform.position = mob_Location[ran_location].transform.position;
        }
        else if (player_Body.in_Wood == true)
        {
            mob1 = objectPool.MakeObj(mob_Wood_str[ran_mob]);
            mob1.transform.position = mob_Location[ran_location].transform.position;
        }
        else if (player_Body.in_Mecha == true)
        {
            mob1 = objectPool.MakeObj(mob_Mecha_str[ran_mob]);
            mob1.transform.position = mob_Location[ran_location].transform.position;
        }
    }

    public void Mob_BigWave_General()
    {
        int ran_mob;//몹 생성 랜덤값
        
        if (player_Body.in_Normal == true)
        {
            for (int i = 0; i < 28; i++)
            {
                GameObject mob;
                ran_mob = Random.Range(0, 2);
                mob = objectPool.MakeObj(mob_Normal_str[ran_mob]);
                mob.transform.position = mob_Location[i].transform.position;
            }
        }
        else if (player_Body.in_Fire == true)
        {
            for (int i = 0; i < 28; i++)
            {
                GameObject mob;
                ran_mob = Random.Range(0, 2);
                mob = objectPool.MakeObj(mob_Fire_str[ran_mob]);
                mob.transform.position = mob_Location[i].transform.position;
            }
        }
        else if (player_Body.in_Wood == true)
        {
            for (int i = 0; i < 28; i++)
            {
                GameObject mob;
                ran_mob = Random.Range(0, 2);
                mob = objectPool.MakeObj(mob_Wood_str[ran_mob]);
                mob.transform.position = mob_Location[i].transform.position;
            }
        }
        else if (player_Body.in_Mecha == true)
        {
            for (int i = 0; i < 28; i++)
            {
                GameObject mob;
                ran_mob = Random.Range(0, 2);
                mob = objectPool.MakeObj(mob_Mecha_str[ran_mob]);
                mob.transform.position = mob_Location[i].transform.position;
            }
        }

    }


    public void Normal_Atk_Letter_General(Vector3 vector3)
    {
        GameObject letter;
        letter = objectPool.MakeObj(letter_str[0]);

        letter.transform.position = vector3;
    }
    public void Fire_Letter_General(Vector3 vector3)
    {
        GameObject letter;
        letter = objectPool.MakeObj(letter_str[1]);

        letter.transform.position = vector3;
    }
    public void Wood_Letter_General(Vector3 vector3)
    {
        GameObject letter;
        letter = objectPool.MakeObj(letter_str[2]);

        letter.transform.position = vector3;
    }
    public void Mehca_Letter_General(Vector3 vector3)
    {
        GameObject letter;
        letter = objectPool.MakeObj(letter_str[3]);

        letter.transform.position = vector3;
    }

    public void Normal_Atk_General()
    {
        float distanceClosetEnemy = Mathf.Infinity;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
            }
        }

        atk_normal = objectPool.MakeObj(atk_str[0]);
        atk_normal.transform.position = player.transform.position;
        Vector3 start = atk_normal.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_normal.transform.rotation = Quaternion.Euler(atk_normal.transform.rotation.x, atk_normal.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
    }
    public void ShadowPartner1_Atk_General()
    {
        float distanceClosetEnemy = Mathf.Infinity;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - shadowPartner1.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
            }
        }

        atk_shadow = objectPool.MakeObj(atk_str[1]);
        atk_shadow.transform.position = shadowPartner1.transform.position;
        Vector3 start = atk_shadow.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_shadow.transform.rotation = Quaternion.Euler(atk_shadow.transform.rotation.x, atk_shadow.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
    }
    public void ShadowPartner2_Atk_General()
    {
        float distanceClosetEnemy = Mathf.Infinity;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - shadowPartner2.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
            }
        }

        atk_shadow = objectPool.MakeObj(atk_str[1]);
        atk_shadow.transform.position = shadowPartner2.transform.position;
        Vector3 start = atk_shadow.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_shadow.transform.rotation = Quaternion.Euler(atk_shadow.transform.rotation.x, atk_shadow.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
    }
    public void Fire1_General()
    {
        GameObject fire1;
        fire1 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;

        if(player.gameObject.transform.localScale.x < 0)
            fire1.transform.localEulerAngles = new Vector3(0, 0, 180);
        else
            fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
    }
    public void Fire2_General()
    {
        GameObject fire1;
        GameObject fire2;
        fire1 = objectPool.MakeObj(atk_str[2]);
        fire2 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;
        fire2.transform.position = player.transform.position;

        fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
        fire2.transform.localEulerAngles = new Vector3(0, 0, 180);
    }
    public void Fire4_General()
    {
        GameObject fire1;
        GameObject fire2;
        GameObject fire3;
        GameObject fire4;
        fire1 = objectPool.MakeObj(atk_str[2]);
        fire2 = objectPool.MakeObj(atk_str[2]);
        fire3 = objectPool.MakeObj(atk_str[2]);
        fire4 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;
        fire2.transform.position = player.transform.position;
        fire3.transform.position = player.transform.position;
        fire4.transform.position = player.transform.position;

        fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
        fire2.transform.localEulerAngles = new Vector3(0, 0, 90);
        fire3.transform.localEulerAngles = new Vector3(0, 0, 180);
        fire4.transform.localEulerAngles = new Vector3(0, 0, 270);
    }
    public void Fire12_General()
    {
        GameObject fire1;
        GameObject fire2;
        GameObject fire3;
        GameObject fire4;
        GameObject fire5;
        GameObject fire6;
        GameObject fire7;
        GameObject fire8;
        GameObject fire9;
        GameObject fire10;
        GameObject fire11;
        GameObject fire12;
        fire1 = objectPool.MakeObj(atk_str[2]);
        fire2 = objectPool.MakeObj(atk_str[2]);
        fire3 = objectPool.MakeObj(atk_str[2]);
        fire4 = objectPool.MakeObj(atk_str[2]);
        fire5 = objectPool.MakeObj(atk_str[2]);
        fire6 = objectPool.MakeObj(atk_str[2]);
        fire7 = objectPool.MakeObj(atk_str[2]);
        fire8 = objectPool.MakeObj(atk_str[2]);
        fire9 = objectPool.MakeObj(atk_str[2]);
        fire10 = objectPool.MakeObj(atk_str[2]);
        fire11 = objectPool.MakeObj(atk_str[2]);
        fire12 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;
        fire2.transform.position = player.transform.position;
        fire3.transform.position = player.transform.position;
        fire4.transform.position = player.transform.position;
        fire5.transform.position = player.transform.position;
        fire6.transform.position = player.transform.position;
        fire7.transform.position = player.transform.position;
        fire8.transform.position = player.transform.position;
        fire9.transform.position = player.transform.position;
        fire10.transform.position = player.transform.position;
        fire11.transform.position = player.transform.position;
        fire12.transform.position = player.transform.position;

        fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
        fire2.transform.localEulerAngles = new Vector3(0, 0, 30);
        fire3.transform.localEulerAngles = new Vector3(0, 0, 60);
        fire4.transform.localEulerAngles = new Vector3(0, 0, 90);
        fire5.transform.localEulerAngles = new Vector3(0, 0, 120);
        fire6.transform.localEulerAngles = new Vector3(0, 0, 150);
        fire7.transform.localEulerAngles = new Vector3(0, 0, 180);
        fire8.transform.localEulerAngles = new Vector3(0, 0, 210);
        fire9.transform.localEulerAngles = new Vector3(0, 0, 240);
        fire10.transform.localEulerAngles = new Vector3(0, 0, 270);
        fire11.transform.localEulerAngles = new Vector3(0, 0, 300);
        fire12.transform.localEulerAngles = new Vector3(0, 0, 330);
    }

    IEnumerator Talisman_General()
    {
        GameObject talisman1;
        talisman1 = objectPool.MakeObj(atk_str[3]);
        talisman1.transform.position = player.transform.position;
        talisman1.transform.localEulerAngles = new Vector3(0, 0, -90);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman2;
        talisman2 = objectPool.MakeObj(atk_str[3]);
        talisman2.transform.position = player.transform.position;
        talisman2.transform.localEulerAngles = new Vector3(0, 0, -80);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman3;
        talisman3 = objectPool.MakeObj(atk_str[3]);
        talisman3.transform.position = player.transform.position;
        talisman3.transform.localEulerAngles = new Vector3(0, 0, -70);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman4;
        talisman4 = objectPool.MakeObj(atk_str[3]);
        talisman4.transform.position = player.transform.position;
        talisman4.transform.localEulerAngles = new Vector3(0, 0, -60);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman5;
        talisman5 = objectPool.MakeObj(atk_str[3]);
        talisman5.transform.position = player.transform.position;
        talisman5.transform.localEulerAngles = new Vector3(0, 0, -50);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman6;
        talisman6 = objectPool.MakeObj(atk_str[3]);
        talisman6.transform.position = player.transform.position;
        talisman6.transform.localEulerAngles = new Vector3(0, 0, -40);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman7;
        talisman7 = objectPool.MakeObj(atk_str[3]);
        talisman7.transform.position = player.transform.position;
        talisman7.transform.localEulerAngles = new Vector3(0, 0, -30);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman8;
        talisman8 = objectPool.MakeObj(atk_str[3]);
        talisman8.transform.position = player.transform.position;
        talisman8.transform.localEulerAngles = new Vector3(0, 0, -20);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman9;
        talisman9 = objectPool.MakeObj(atk_str[3]);
        talisman9.transform.position = player.transform.position;
        talisman9.transform.localEulerAngles = new Vector3(0, 0, -10);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman10;
        talisman10 = objectPool.MakeObj(atk_str[3]);
        talisman10.transform.position = player.transform.position;
        talisman10.transform.localEulerAngles = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman11;
        talisman11 = objectPool.MakeObj(atk_str[3]);
        talisman11.transform.position = player.transform.position;
        talisman11.transform.localEulerAngles = new Vector3(0, 0, 10);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman12;
        talisman12 = objectPool.MakeObj(atk_str[3]);
        talisman12.transform.position = player.transform.position;
        talisman12.transform.localEulerAngles = new Vector3(0, 0, 20);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman13;
        talisman13 = objectPool.MakeObj(atk_str[3]);
        talisman13.transform.position = player.transform.position;
        talisman13.transform.localEulerAngles = new Vector3(0, 0, 30);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman14;
        talisman14 = objectPool.MakeObj(atk_str[3]);
        talisman14.transform.position = player.transform.position;
        talisman14.transform.localEulerAngles = new Vector3(0, 0, 40);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman15;
        talisman15 = objectPool.MakeObj(atk_str[3]);
        talisman15.transform.position = player.transform.position;
        talisman15.transform.localEulerAngles = new Vector3(0, 0, 50);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman16;
        talisman16 = objectPool.MakeObj(atk_str[3]);
        talisman16.transform.position = player.transform.position;
        talisman16.transform.localEulerAngles = new Vector3(0, 0, 60);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman17;
        talisman17 = objectPool.MakeObj(atk_str[3]);
        talisman17.transform.position = player.transform.position;
        talisman17.transform.localEulerAngles = new Vector3(0, 0, 70);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman18;
        talisman18 = objectPool.MakeObj(atk_str[3]);
        talisman18.transform.position = player.transform.position;
        talisman18.transform.localEulerAngles = new Vector3(0, 0, 80);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman19;
        talisman19 = objectPool.MakeObj(atk_str[3]);
        talisman19.transform.position = player.transform.position;
        talisman19.transform.localEulerAngles = new Vector3(0, 0, 90);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman20;
        talisman20 = objectPool.MakeObj(atk_str[3]);
        talisman20.transform.position = player.transform.position;
        talisman20.transform.localEulerAngles = new Vector3(0, 0, 100);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman21;
        talisman21 = objectPool.MakeObj(atk_str[3]);
        talisman21.transform.position = player.transform.position;
        talisman21.transform.localEulerAngles = new Vector3(0, 0, 110);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman22;
        talisman22 = objectPool.MakeObj(atk_str[3]);
        talisman22.transform.position = player.transform.position;
        talisman22.transform.localEulerAngles = new Vector3(0, 0, 120);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman23;
        talisman23 = objectPool.MakeObj(atk_str[3]);
        talisman23.transform.position = player.transform.position;
        talisman23.transform.localEulerAngles = new Vector3(0, 0, 130);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman24;
        talisman24 = objectPool.MakeObj(atk_str[3]);
        talisman24.transform.position = player.transform.position;
        talisman24.transform.localEulerAngles = new Vector3(0, 0, 140);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman25;
        talisman25 = objectPool.MakeObj(atk_str[3]);
        talisman25.transform.position = player.transform.position;
        talisman25.transform.localEulerAngles = new Vector3(0, 0, 150);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman26;
        talisman26 = objectPool.MakeObj(atk_str[3]);
        talisman26.transform.position = player.transform.position;
        talisman26.transform.localEulerAngles = new Vector3(0, 0, 160);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman27;
        talisman27 = objectPool.MakeObj(atk_str[3]);
        talisman27.transform.position = player.transform.position;
        talisman27.transform.localEulerAngles = new Vector3(0, 0, 170);
        yield return new WaitForSeconds(0.1f);


        GameObject talisman28;
        talisman28 = objectPool.MakeObj(atk_str[3]);
        talisman28.transform.position = player.transform.position;
        talisman28.transform.localEulerAngles = new Vector3(0, 0, 180);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman29;
        talisman29 = objectPool.MakeObj(atk_str[3]);
        talisman29.transform.position = player.transform.position;
        talisman29.transform.localEulerAngles = new Vector3(0, 0, 190);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman30;
        talisman30 = objectPool.MakeObj(atk_str[3]);
        talisman30.transform.position = player.transform.position;
        talisman30.transform.localEulerAngles = new Vector3(0, 0, 200);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman31;
        talisman31 = objectPool.MakeObj(atk_str[3]);
        talisman31.transform.position = player.transform.position;
        talisman31.transform.localEulerAngles = new Vector3(0, 0, 210);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman32;
        talisman32 = objectPool.MakeObj(atk_str[3]);
        talisman32.transform.position = player.transform.position;
        talisman32.transform.localEulerAngles = new Vector3(0, 0, 220);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman33;
        talisman33 = objectPool.MakeObj(atk_str[3]);
        talisman33.transform.position = player.transform.position;
        talisman33.transform.localEulerAngles = new Vector3(0, 0, 230);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman34;
        talisman34 = objectPool.MakeObj(atk_str[3]);
        talisman34.transform.position = player.transform.position;
        talisman34.transform.localEulerAngles = new Vector3(0, 0, 240);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman35;
        talisman35 = objectPool.MakeObj(atk_str[3]);
        talisman35.transform.position = player.transform.position;
        talisman35.transform.localEulerAngles = new Vector3(0, 0, 250);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman36;
        talisman36 = objectPool.MakeObj(atk_str[3]);
        talisman36.transform.position = player.transform.position;
        talisman36.transform.localEulerAngles = new Vector3(0, 0, 260);
        yield return new WaitForSeconds(0.1f);

    }

    public void FireColumn_General()
    {
        
        float distanceClosetEnemy = 13f;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
                frieColumn = objectPool.MakeObj(atk_str[4]);
                frieColumn.transform.position = closetEnemy.transform.position;
                break;
            }
        }

        /*Vector3 start = atk_normal.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_normal.transform.rotation = Quaternion.Euler(atk_normal.transform.rotation.x, atk_normal.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);*/
    }

    public void Tornado_General()
    {
        GameObject tornado;

        tornado = objectPool.MakeObj(atk_str[5]);
        tornado.gameObject.transform.position = player.transform.position;
    }
    
    public void Tree_General()
    {
        GameObject tree;

        tree = objectPool.MakeObj(atk_str[6]);
        tree.gameObject.transform.position = player.transform.position;
    }

    public void Boomerang_General()
    {
        GameObject boomerang;

        boomerang = objectPool.MakeObj(atk_str[7]);
        boomerang.gameObject.transform.position = player.transform.position;
    }

    public void Electric_General()
    {
        float distanceClosetEnemy = 13f;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
                electricity = objectPool.MakeObj(atk_str[8]);
                electricity.transform.position = closetEnemy.transform.position;
                break;
            }
        }
    }

    public void WindWall_General()
    {
        GameObject windwall;

        windwall = objectPool.MakeObj(atk_str[9]);
        windwall.gameObject.transform.position = player.transform.position;
    }

    public void Wind_General()
    {
        float distanceClosetEnemy = 13f;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
                wind = objectPool.MakeObj(atk_str[10]);
                wind.transform.position = player.transform.position;
                Vector3 start = wind.transform.position;
                Vector3 end = closetEnemy.transform.position;
                Vector3 fin = end - start;
                wind.transform.rotation = Quaternion.Euler(wind.transform.rotation.x, wind.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
                break;
            }
        }
    }
}
