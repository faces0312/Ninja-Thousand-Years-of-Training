using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msaTreeEffect : MonoBehaviour
{
    //1�ʿ� 1hp ȸ��
    //Ʈ���� ���� ������ 1���� ��Ÿ���� �پ���
    //1���� ��Ÿ�� ���� �پ������� player�� ü���� �ִ밡 �ƴ϶�� ü�� +1
    //10�� �� ���� ������Ʈ �����

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
    { //������Ʈ�� �浹�� �Ͼ�� ���� ���������� ȣ��Ǵ� �Լ�
        if (collision.gameObject.tag == "PlayerBody")
        {
            if (tree_Tmp_CT > 0) //hp�� ä���ִ� ��Ÿ��
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
