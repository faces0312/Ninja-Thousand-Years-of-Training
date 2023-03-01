using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    GameObject[] targetPool;

    //°ø°Ý Å¸°Ù
    public GameObject player_nomralAtk_Prefab;
    GameObject[] player_nomralAtk;
    public GameObject player_shadowAtk_Prefab;
    GameObject[] player_shadowAtk;
    public GameObject player_Fire_Prefab;
    GameObject[] player_Fire;
    public GameObject player_Talisman_Prefab;
    GameObject[] player_Talisman;
    public GameObject player_FireColumn_Prefab;
    GameObject[] player_FireColumn;
    public GameObject player_Tornado_Prefab;
    GameObject[] player_Tornado;
    public GameObject player_Tree_Prefab;
    GameObject[] player_Tree;
    public GameObject player_Boomerang_Prefab;
    GameObject[] player_Boomerang;
    public GameObject player_Electricity_Prefab;
    GameObject[] player_Electricity;
    public GameObject player_WindWall_Prefab;
    GameObject[] player_WindWall;
    public GameObject player_Wind_Prefab;
    GameObject[] player_Wind;

    //º¸½º Å¸°Ù
    public GameObject bat_Boss_Prefab;
    GameObject[] bat_Boss;
    public GameObject golem_Boss_Prefab;
    GameObject[] golem_Boss;
    public GameObject redspit_Boss_Prefab;
    GameObject[] redspit_Boss;

    //¹ÚÁã º¸½º °ø°Ý Å¸°Ù
    public GameObject bat_Boss_ShotGun_Prefab;
    GameObject[] bat_Boss_ShotGun;
    public GameObject bat_Boss_GunGroup_Prefab;
    GameObject[] bat_Boss_GunGroup;

    //°ñ·½ º¸½º °ø°Ý
    public GameObject golem_Boss_Lighting_Prefab;
    GameObject[] golem_Boss_Lighting;
    public GameObject golem_Boss_Wire_Prefab;
    GameObject[] golem_Boss_Wire;

    //Áö··ÀÌ º¸½º °ø°Ý
    public GameObject redspit_Boss_Arrow_Prefab;
    GameObject[] redspit_Boss_Arrow;
    public GameObject redspit_Boss_MachineGun_Prefab;
    GameObject[] redspit_Boss_MachineGun;
    public GameObject redspit_Boss_Cremore_Prefab;
    GameObject[] redspit_Boss_Cremore;

    //¸÷ Å¸°Ù
    public GameObject mob1_Prefab;
    GameObject[] mob1;
    public GameObject rayven_Prefab;
    GameObject[] rayven;
    public GameObject redspit_Prefab;
    GameObject[] redspit;
    public GameObject wifi_Prefab;
    GameObject[] wifi;
    public GameObject bat_Normal_Prefab;
    GameObject[] bat_Normal;
    public GameObject bat_Fire_Prefab;
    GameObject[] bat_Fire;
    public GameObject bat_Wood_Prefab;
    GameObject[] bat_Wood;
    public GameObject bat_Mecha_Prefab;
    GameObject[] bat_Mecha;
    public GameObject zombie_normal_Prefab;
    GameObject[] zombie_normal;
    public GameObject fox_Fire_Prefab;
    GameObject[] fox_Fire;
    public GameObject tree_Wood_Prefab;
    GameObject[] tree_Wood;
    public GameObject tree_Mecha_Prefab;
    GameObject[] tree_Mecha;
    public GameObject golem_Normal_Prefab;
    GameObject[] golem_Normal;
    public GameObject golem_Fire_Prefab;
    GameObject[] golem_Fire;
    public GameObject golem_Wood_Prefab;
    GameObject[] golem_Wood;
    public GameObject golem_Mecha_Prefab;
    GameObject[] golem_Mecha;


    //ºñ±Þ¼­ Å¸°Ù
    public GameObject normalAkt_letter_Prefab;
    GameObject[] normalAkt_letter;
    public GameObject fire_letter_Prefab;
    GameObject[] fire_letter;
    public GameObject wood_letter_Prefab;
    GameObject[] wood_letter;
    public GameObject mecha_letter_Prefab;
    GameObject[] mecha_letter;

    // Start is called before the first frame update
    void Start()
    {
        bat_Boss = new GameObject[5];
        golem_Boss = new GameObject[5];
        redspit_Boss = new GameObject[5];

        bat_Boss_ShotGun = new GameObject[10];
        bat_Boss_GunGroup = new GameObject[5];

        golem_Boss_Lighting = new GameObject[80];
        golem_Boss_Wire = new GameObject[30];

        redspit_Boss_Arrow = new GameObject[15];
        redspit_Boss_MachineGun = new GameObject[100];
        redspit_Boss_Cremore = new GameObject[20];


        mob1 = new GameObject[300];
        rayven = new GameObject[300];
        redspit = new GameObject[300];
        wifi = new GameObject[300];
        bat_Normal = new GameObject[300];
        bat_Fire = new GameObject[300];
        bat_Wood = new GameObject[300];
        bat_Mecha = new GameObject[300];
        zombie_normal = new GameObject[300];
        fox_Fire = new GameObject[300];
        tree_Wood = new GameObject[300];
        tree_Mecha = new GameObject[300];
        golem_Normal = new GameObject[300];
        golem_Fire = new GameObject[300];
        golem_Wood = new GameObject[300];
        golem_Mecha = new GameObject[300];

        player_nomralAtk = new GameObject[20];
        player_shadowAtk = new GameObject[20];
        player_Fire = new GameObject[24];
        player_Talisman = new GameObject[36];
        player_FireColumn = new GameObject[20];
        player_Tornado = new GameObject[5];
        player_Tree = new GameObject[3];
        player_Boomerang = new GameObject[10];
        player_Electricity = new GameObject[10];
        player_WindWall = new GameObject[5];
        player_Wind = new GameObject[5];

        normalAkt_letter = new GameObject[30];
        fire_letter = new GameObject[30];
        wood_letter = new GameObject[30];
        mecha_letter = new GameObject[30];

        Generate();
    }

    void Generate()
    {
        for (int index = 0; index < bat_Boss.Length; index++)
        {
            bat_Boss[index] = Instantiate(bat_Boss_Prefab);
            bat_Boss[index].SetActive(false);
        }
        for (int index = 0; index < bat_Boss_ShotGun.Length; index++)
        {
            bat_Boss_ShotGun[index] = Instantiate(bat_Boss_ShotGun_Prefab);
            bat_Boss_ShotGun[index].SetActive(false);
        }
        for (int index = 0; index < bat_Boss_GunGroup.Length; index++)
        {
            bat_Boss_GunGroup[index] = Instantiate(bat_Boss_GunGroup_Prefab);
            bat_Boss_GunGroup[index].SetActive(false);
        }
        for (int index = 0; index < golem_Boss.Length; index++)
        {
            golem_Boss[index] = Instantiate(golem_Boss_Prefab);
            golem_Boss[index].SetActive(false);
        }
        for (int index = 0; index < golem_Boss_Lighting.Length; index++)
        {
            golem_Boss_Lighting[index] = Instantiate(golem_Boss_Lighting_Prefab);
            golem_Boss_Lighting[index].SetActive(false);
        }
        for (int index = 0; index < golem_Boss_Wire.Length; index++)
        {
            golem_Boss_Wire[index] = Instantiate(golem_Boss_Wire_Prefab);
            golem_Boss_Wire[index].SetActive(false);
        }
        for (int index = 0; index < redspit_Boss.Length; index++)
        {
            redspit_Boss[index] = Instantiate(redspit_Boss_Prefab);
            redspit_Boss[index].SetActive(false);
        }
        for (int index = 0; index < redspit_Boss_Arrow.Length; index++)
        {
            redspit_Boss_Arrow[index] = Instantiate(redspit_Boss_Arrow_Prefab);
            redspit_Boss_Arrow[index].SetActive(false);
        }
        for (int index = 0; index < redspit_Boss_MachineGun.Length; index++)
        {
            redspit_Boss_MachineGun[index] = Instantiate(redspit_Boss_MachineGun_Prefab);
            redspit_Boss_MachineGun[index].SetActive(false);
        }
        for (int index = 0; index < redspit_Boss_Cremore.Length; index++)
        {
            redspit_Boss_Cremore[index] = Instantiate(redspit_Boss_Cremore_Prefab);
            redspit_Boss_Cremore[index].SetActive(false);
        }
        for (int index = 0; index < mob1.Length; index++)
        {
            mob1[index] = Instantiate(mob1_Prefab);
            mob1[index].SetActive(false);
        }
        for (int index = 0; index < rayven.Length; index++)
        {
            rayven[index] = Instantiate(rayven_Prefab);
            rayven[index].SetActive(false);
        }
        for (int index = 0; index < redspit.Length; index++)
        {
            redspit[index] = Instantiate(redspit_Prefab);
            redspit[index].SetActive(false);
        }
        for (int index = 0; index < wifi.Length; index++)
        {
            wifi[index] = Instantiate(wifi_Prefab);
            wifi[index].SetActive(false);
        }
        for (int index = 0; index < bat_Normal.Length; index++)
        {
            bat_Normal[index] = Instantiate(bat_Normal_Prefab);
            bat_Normal[index].SetActive(false);
        }
        for (int index = 0; index < bat_Fire.Length; index++)
        {
            bat_Fire[index] = Instantiate(bat_Fire_Prefab);
            bat_Fire[index].SetActive(false);
        }
        for (int index = 0; index < bat_Wood.Length; index++)
        {
            bat_Wood[index] = Instantiate(bat_Wood_Prefab);
            bat_Wood[index].SetActive(false);
        }
        for (int index = 0; index < bat_Mecha.Length; index++)
        {
            bat_Mecha[index] = Instantiate(bat_Mecha_Prefab);
            bat_Mecha[index].SetActive(false);
        }
        for (int index = 0; index < zombie_normal.Length; index++)
        {
            zombie_normal[index] = Instantiate(zombie_normal_Prefab);
            zombie_normal[index].SetActive(false);
        }
        for (int index = 0; index < fox_Fire.Length; index++)
        {
            fox_Fire[index] = Instantiate(fox_Fire_Prefab);
            fox_Fire[index].SetActive(false);
        }
        for (int index = 0; index < tree_Wood.Length; index++)
        {
            tree_Wood[index] = Instantiate(tree_Wood_Prefab);
            tree_Wood[index].SetActive(false);
        }
        for (int index = 0; index < tree_Mecha.Length; index++)
        {
            tree_Mecha[index] = Instantiate(tree_Mecha_Prefab);
            tree_Mecha[index].SetActive(false);
        }
        for (int index = 0; index < golem_Normal.Length; index++)
        {
            golem_Normal[index] = Instantiate(golem_Normal_Prefab);
            golem_Normal[index].SetActive(false);
        }
        for (int index = 0; index < golem_Fire.Length; index++)
        {
            golem_Fire[index] = Instantiate(golem_Fire_Prefab);
            golem_Fire[index].SetActive(false);
        }
        for (int index = 0; index < golem_Wood.Length; index++)
        {
            golem_Wood[index] = Instantiate(golem_Wood_Prefab);
            golem_Wood[index].SetActive(false);
        }
        for (int index = 0; index < golem_Mecha.Length; index++)
        {
            golem_Mecha[index] = Instantiate(golem_Mecha_Prefab);
            golem_Mecha[index].SetActive(false);
        }
        for (int index = 0; index < player_nomralAtk.Length; index++)
        {
            player_nomralAtk[index] = Instantiate(player_nomralAtk_Prefab);
            player_nomralAtk[index].SetActive(false);
        }
        for (int index = 0; index < player_shadowAtk.Length; index++)
        {
            player_shadowAtk[index] = Instantiate(player_shadowAtk_Prefab);
            player_shadowAtk[index].SetActive(false);
        }
        for (int index = 0; index < player_Fire.Length; index++)
        {
            player_Fire[index] = Instantiate(player_Fire_Prefab);
            player_Fire[index].SetActive(false);
        }
        for (int index = 0; index < player_Talisman.Length; index++)
        {
            player_Talisman[index] = Instantiate(player_Talisman_Prefab);
            player_Talisman[index].SetActive(false);
        }
        for (int index = 0; index < player_FireColumn.Length; index++)
        {
            player_FireColumn[index] = Instantiate(player_FireColumn_Prefab);
            player_FireColumn[index].SetActive(false);
        }
        for (int index = 0; index < player_Tornado.Length; index++)
        {
            player_Tornado[index] = Instantiate(player_Tornado_Prefab);
            player_Tornado[index].SetActive(false);
        }
        for (int index = 0; index < player_Tree.Length; index++)
        {
            player_Tree[index] = Instantiate(player_Tree_Prefab); //»ý¼º
            player_Tree[index].SetActive(false); //ÀÏ´Ü ²¨³õ±â
        }
        for (int index = 0; index < player_Boomerang.Length; index++)
        {
            player_Boomerang[index] = Instantiate(player_Boomerang_Prefab); //»ý¼º
            player_Boomerang[index].SetActive(false); //ÀÏ´Ü ²¨³õ±â
        }
        for (int index = 0; index < player_Electricity.Length; index++)
        {
            player_Electricity[index] = Instantiate(player_Electricity_Prefab); //»ý¼º
            player_Electricity[index].SetActive(false); //ÀÏ´Ü ²¨³õ±â
        }
        for (int index = 0; index < player_WindWall.Length; index++)
        {
            player_WindWall[index] = Instantiate(player_WindWall_Prefab); //»ý¼º
            player_WindWall[index].SetActive(false); //ÀÏ´Ü ²¨³õ±â
        }
        for (int index = 0; index < player_Wind.Length; index++)
        {
            player_Wind[index] = Instantiate(player_Wind_Prefab); //»ý¼º
            player_Wind[index].SetActive(false); //ÀÏ´Ü ²¨³õ±â
        }
        for (int index = 0; index < normalAkt_letter.Length; index++)
        {
            normalAkt_letter[index] = Instantiate(normalAkt_letter_Prefab);
            normalAkt_letter[index].SetActive(false);
        }
        for (int index = 0; index < fire_letter.Length; index++)
        {
            fire_letter[index] = Instantiate(fire_letter_Prefab);
            fire_letter[index].SetActive(false);
        }
        for (int index = 0; index < wood_letter.Length; index++)
        {
            wood_letter[index] = Instantiate(wood_letter_Prefab);
            wood_letter[index].SetActive(false);
        }
        for (int index = 0; index < mecha_letter.Length; index++)
        {
            mecha_letter[index] = Instantiate(mecha_letter_Prefab);
            mecha_letter[index].SetActive(false);
        }
    }

    public GameObject MakeObj(string type)
    {
        switch (type)
        {
            case "Normal_Atk":
                targetPool = player_nomralAtk;  //»ý¼ºÇØ¶ó
                break;
            case "Shadow_Atk":
                targetPool = player_shadowAtk;
                break;
            case "Fire":
                targetPool = player_Fire;
                break;
            case "Talisman":
                targetPool = player_Talisman;
                break;
            case "FireColumn":
                targetPool = player_FireColumn;
                break;
            case "Tornado":
                targetPool = player_Tornado;
                break;
            case "Bat_Boss":
                targetPool = bat_Boss;
                break;
            case "Bat_Boss_ShotGun":
                targetPool = bat_Boss_ShotGun;
                break;
            case "Bat_Boss_GunGroup":
                targetPool = bat_Boss_GunGroup;
                break;
            case "Golem_Boss":
                targetPool = golem_Boss;
                break;
            case "Golem_Boss_Lighting":
                targetPool = golem_Boss_Lighting;
                break;
            case "Golem_Boss_Wire":
                targetPool = golem_Boss_Wire;
                break;
            case "Redspit_Boss":
                targetPool = redspit_Boss;
                break;
            case "Redspit_Boss_Arrow":
                targetPool = redspit_Boss_Arrow;
                break;
            case "Redspit_Boss_MachineGun":
                targetPool = redspit_Boss_MachineGun;
                break;
            case "Redspit_Boss_Cremore":
                targetPool = redspit_Boss_Cremore;
                break;
            case "Mob1":
                targetPool = mob1; 
                break;
            case "Rayven":
                targetPool = rayven;
                break;
            case "Redspit":
                targetPool = redspit;
                break;
            case "Wifi":
                targetPool = wifi;
                break;
            case "Bat_Normal":
                targetPool = bat_Normal;
                break;
            case "Bat_Fire":
                targetPool = bat_Fire;
                break;
            case "Bat_Wood":
                targetPool = bat_Wood;
                break;
            case "Bat_Mecha":
                targetPool = bat_Mecha;
                break;
            case "Zombie_Normal":
                targetPool = zombie_normal;
                break;
            case "Fox_Fire":
                targetPool = fox_Fire;
                break;
            case "Tree_Wood":
                targetPool = tree_Wood;
                break;
            case "Tree_Mecha":
                targetPool = tree_Mecha;
                break;
            case "Golem_Normal":
                targetPool = golem_Normal;
                break;
            case "Golem_Fire":
                targetPool = golem_Fire;
                break;
            case "Golem_Wood":
                targetPool = golem_Wood;
                break;
            case "Golem_Mecha":
                targetPool = golem_Mecha;
                break;
            case "Tree":
                targetPool = player_Tree;
                break;
            case "Boomerang":
                targetPool = player_Boomerang;
                break;
            case "Electricity":
                targetPool = player_Electricity;
                break;
            case "WindWall":
                targetPool = player_WindWall;
                break;
            case "Wind":
                targetPool = player_Wind;
                break;
            case "Normal_Atk_Letter":
                targetPool = normalAkt_letter;
                break;
            case "Fire_Letter":
                targetPool = fire_letter;
                break;
            case "Wood_Letter":
                targetPool = wood_letter;
                break;
            case "Mecha_Letter":
                targetPool = mecha_letter;
                break;

        }
        for (int index = 0; index < targetPool.Length; index++)
        {
            if (!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);
                return targetPool[index];
            }
        }

        return null;
    }
}
