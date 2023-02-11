using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//�ٸ� �κп��� �����ϰ� �ʹٸ�, DataController.Instance.SaveGameData()

[Serializable]
public class GameData
{
    //�ΰ��ӤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�
    //public float exp;

    public float player_hp;//�÷��̾� ü��
    public Vector2 player_Location;

    //�÷��̾� ��ų
    public int normal_atk_lv;//ǥâ
    public int shadow_partner_lv;//�н�
    public int fire_lv;//ȭ��
    public int wind_lv;//ǳ��
    public int talisman_lv;//����
    public int fire_column_lv;//�ұ��
    public int voltTackle_lv;//��Ʈ��Ŭ
    public int tornado_lv;//����̵�
    public int tree_lv; // Ʈ��
    public int boomerang_lv; // �θ޶�
    public int electricity_lv; // �����ǽ� ������ ��
    public int windwall_lv; //

    //�� ü��
    public float mob1_hp;
    public float bat_normal_hp;
    public float bat_fire_hp;
    public float bat_wood_hp;
    public float bat_mecha_hp;

    //�� ���ݷ�
    public float mob1_dmg;
    public float bat_body_dmg;
    public float bat_atk_dmg;
    //�ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

}

