using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msaTreeEffect : MonoBehaviour
{
    //1초에 1hp 회복
    //트리거 내에 있을때 1초의 쿨타임이 줄어들게
    //1초의 쿨타임 전부 줄어들었을때 player의 체력이 최대가 아니라면 체력 +1
    //10초 뒤 나무 오브젝트 사라짐

    // Start is called before the first frame update


    public float tree_CT;
    public float tree_Tmp_CT;
    //aadadaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    private void OnEnable()
    {
        tree_CT = 1f;
        tree_Tmp_CT = tree_CT;
        // Manager.manager.player.hp 
        StartCoroutine(dis_tree());

    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator dis_tree()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }
    

    private void OnTriggerStay2D(Collider2D collision)
    { //오브젝트간 충돌이 일어나는 동안 지속적으로 호출되는 함수
        if (collision.gameObject.tag == "PlayerBody")
        {
            if (tree_Tmp_CT > 0) //hp를 채워주는 쿨타임
                tree_Tmp_CT -= Time.deltaTime;
            else
            {
                if(Manager.manager.player.hp < Manager.manager.player.hp_max)
                {
                    Manager.manager.player.hp++;
                    tree_Tmp_CT = tree_CT;
                }
                   
            }

        }
    }
}
