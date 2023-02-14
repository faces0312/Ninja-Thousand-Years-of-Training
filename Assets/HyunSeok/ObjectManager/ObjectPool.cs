using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    GameObject[] targetPool;

    //傍拜 鸥百
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


    //各 鸥百
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

    //厚鞭辑 鸥百
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
        mob1 = new GameObject[300];
        rayven = new GameObject[300];
        redspit = new GameObject[300];
        wifi = new GameObject[300];
        bat_Normal = new GameObject[300];
        bat_Fire = new GameObject[300];
        bat_Wood = new GameObject[300];
        bat_Mecha = new GameObject[300];

        player_nomralAtk = new GameObject[20];
        player_shadowAtk = new GameObject[20];
        player_Fire = new GameObject[24];
        player_Talisman = new GameObject[36];
        player_FireColumn = new GameObject[5];
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
            player_Tree[index] = Instantiate(player_Tree_Prefab); //积己
            player_Tree[index].SetActive(false); //老窜 波初扁
        }
        for (int index = 0; index < player_Boomerang.Length; index++)
        {
            player_Boomerang[index] = Instantiate(player_Boomerang_Prefab); //积己
            player_Boomerang[index].SetActive(false); //老窜 波初扁
        }
        for (int index = 0; index < player_Electricity.Length; index++)
        {
            player_Electricity[index] = Instantiate(player_Electricity_Prefab); //积己
            player_Electricity[index].SetActive(false); //老窜 波初扁
        }
        for (int index = 0; index < player_WindWall.Length; index++)
        {
            player_WindWall[index] = Instantiate(player_WindWall_Prefab); //积己
            player_WindWall[index].SetActive(false); //老窜 波初扁
        }
        for (int index = 0; index < player_Wind.Length; index++)
        {
            player_Wind[index] = Instantiate(player_Wind_Prefab); //积己
            player_Wind[index].SetActive(false); //老窜 波初扁
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
                targetPool = player_nomralAtk;  //积己秦扼
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
