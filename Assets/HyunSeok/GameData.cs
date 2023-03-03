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

    public int skill_cnt;//몇개의 스킬을 가지고 있는지(최대 6개)

    public float player_hp;//플레이어 체력

    public float player_normal;//플레이어 무 속성 데미지
    public float player_fire;//플레이어 불 속성 데미지
    public float player_wood;//플레이어 숲 속성 데미지
    public float player_mecha;//플레이어 기계 속성 데미지


    //플레이어 스킬
    public int drop_percent;//드랍 확률
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

    public int boss_cnt;
    public int mob_cnt;
    //몹 체력
    public float mob1_hp;//벌레형 체력
    public float bat_hp;
    public float gatekeeper_hp;
    public float golem_hp;

    public float bat_boss_hp;

    //몹 공격력
    public float mob1_dmg;
    public float bat_body_dmg;
    public float bat_atk_dmg;
    public float gatekeeper_dmg;
    public float golem_dmg;


    public float bat_boss_body;
    public float bat_boss_atk;
    public float bat_boss_laser;

    public float golem_boss_body;
    public float golem_boss_lighting;
    public float golem_boss_wire;
    public float golem_boss_laser;

    public float redspit_boss_body;
    public float redspit_boss_atk;


    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

}

