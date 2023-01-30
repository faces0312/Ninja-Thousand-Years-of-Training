using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager manager;
    public ObjectManager objectManager;
    public Player player;
    public Mob1 mob;  //°Çµé

    public int lv;
    public float exp_Tmp;
    public Slider exp_Bar;

    public float play_time;
    private void Awake()
    {
        manager = this;
    }
    // Start is called before the first frame update
    void Start()
    {
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
//<<<<<<< HEAD
        Data.Instance.gameData.electricity_lv = 0;
        Data.Instance.gameData.windwall_lv = 0;
//=======
//>>>>>>> 9c799be554b5ba7c15336efdb075ce872ec3a481


        lv = 1;
        Data.Instance.gameData.exp = 0;
        exp_Tmp = 100;

        Invoke("Exp_Practice",1f);
    }

    private void Update()
    {
        play_time += Time.deltaTime;

        exp_Bar.value = Data.Instance.gameData.exp / exp_Tmp;

        if(Data.Instance.gameData.exp >= exp_Tmp)
        {
            Data.Instance.gameData.exp -= exp_Tmp;
            exp_Tmp *= 2;
            lv++;
        }
    }

    public void Exp_Practice()
    {
        Data.Instance.gameData.exp += 10;
        Invoke("Exp_Practice", 1f);
    }

}
