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

    public int skill_cnt;//��� ��ų�� ������ �ִ���(�ִ� 6��)

    public float player_hp;//�÷��̾� ü��

    public float player_normal;//�÷��̾� �� �Ӽ� ������
    public float player_fire;//�÷��̾� �� �Ӽ� ������
    public float player_wood;//�÷��̾� �� �Ӽ� ������
    public float player_mecha;//�÷��̾� ��� �Ӽ� ������


    //�÷��̾� ��ų
    public int drop_percent;//��� Ȯ��
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

    public int boss_cnt;
    public int mob_cnt;
    //�� ü��
    public float mob1_hp;//������ ü��
    public float bat_hp;
    public float gatekeeper_hp;
    public float golem_hp;

    public float bat_boss_hp;

    //�� ���ݷ�
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


    //�ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

}

