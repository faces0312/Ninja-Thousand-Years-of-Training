using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{

    private Slider hpbar;

    private float maxHP = Data.Instance.gameData.player_hp;
    private float curHP; //어케연결하지 




    // Start is called before the first frame update
    void Start()
    {
        hpbar.value = (float)curHP / (float)maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        HP();
        // 오브젝트에 따른 HP Bar 위치 이동
        //hpbar.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));
    }

    private void HP()
    {
        hpbar.value = (float)curHP / (float)maxHP;
    }
}
