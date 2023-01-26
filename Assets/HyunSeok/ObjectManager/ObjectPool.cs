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
    public GameObject player_Lighting_Prefab;
    GameObject[] player_Lighting;
    public GameObject player_Talisman_Prefab;
    GameObject[] player_Talisman;
    public GameObject player_FireColumn_Prefab;
    GameObject[] player_FireColumn;
    public GameObject player_WoodTrap_Prefab;
    GameObject[] player_WoodTrap;
    public GameObject player_Tornado_Prefab;
    GameObject[] player_Tornado;


    //¸÷ Å¸°Ù
    public GameObject mob1_Prefab;
    GameObject[] mob1;

    //ºñ±Þ¼­ Å¸°Ù
    public GameObject normalAkt_letter_Prefab;
    GameObject[] normalAkt_letter;

    // Start is called before the first frame update
    void Start()
    {
        mob1 = new GameObject[100];
        player_nomralAtk = new GameObject[40];
        player_shadowAtk = new GameObject[100];
        player_Fire = new GameObject[24];
        player_Lighting = new GameObject[12];
        player_Talisman = new GameObject[36];
        player_FireColumn = new GameObject[5];
        player_WoodTrap = new GameObject[5];
        player_Tornado = new GameObject[5];


        normalAkt_letter = new GameObject[10];

        Generate();
    }

    void Generate()
    {
        for (int index = 0; index < mob1.Length; index++)
        {
            mob1[index] = Instantiate(mob1_Prefab);
            mob1[index].SetActive(false);
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
        for (int index = 0; index < player_Lighting.Length; index++)
        {
            player_Lighting[index] = Instantiate(player_Lighting_Prefab);
            player_Lighting[index].SetActive(false);
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
        for (int index = 0; index < player_WoodTrap.Length; index++)
        {
            player_WoodTrap[index] = Instantiate(player_WoodTrap_Prefab);
            player_WoodTrap[index].SetActive(false);
        }
        for (int index = 0; index < player_Tornado.Length; index++)
        {
            player_Tornado[index] = Instantiate(player_Tornado_Prefab);
            player_Tornado[index].SetActive(false);
        }
        for (int index = 0; index < normalAkt_letter.Length; index++)
        {
            normalAkt_letter[index] = Instantiate(normalAkt_letter_Prefab);
            normalAkt_letter[index].SetActive(false);
        }
    }

    public GameObject MakeObj(string type)
    {
        switch (type)
        {
            case "Normal_Atk":
                targetPool = player_nomralAtk;
                break;
            case "Shadow_Atk":
                targetPool = player_shadowAtk;
                break;
            case "Fire":
                targetPool = player_Fire;
                break;
            case "Lighting":
                targetPool = player_Lighting;
                break;
            case "Talisman":
                targetPool = player_Talisman;
                break;
            case "FireColumn":
                targetPool = player_FireColumn;
                break;
            case "WoodTrap":
                targetPool = player_WoodTrap;
                break;
            case "Tornado":
                targetPool = player_Tornado;
                break;
            case "Mob1":
                targetPool = mob1;
                break;
            case "Normal_Atk_Letter":
                targetPool = normalAkt_letter;
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
