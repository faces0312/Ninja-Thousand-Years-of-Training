using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//다른 부분에서 저장하고 싶다면, DataController.Instance.SaveGameData()

[Serializable]
public class GameData
{
    //인게임ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    //public float exp;

    public float player_hp;//플레이어 체력
    public Vector2 player_Location;

    //플레이어 스킬
    public int normal_atk_lv;//표창
    public int shadow_partner_lv;//분신
    public int fire_lv;//화둔
    public int wind_lv;//풍둔
    public int talisman_lv;//부적
    public int fire_column_lv;//불기둥
    public int voltTackle_lv;//볼트태클
    public int tornado_lv;//토네이도
    public int tree_lv; // 트리
    public int boomerang_lv; // 부메랑
    public int electricity_lv; // 번개의신 번개의 왕
    public int windwall_lv; //

    //몹 체력
    public float mob1_hp;
    public float bat_normal_hp;
    public float bat_fire_hp;
    public float bat_wood_hp;
    public float bat_mecha_hp;

    //몹 공격력
    public float mob1_dmg;
    public float bat_body_dmg;
    public float bat_atk_dmg;
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

}

