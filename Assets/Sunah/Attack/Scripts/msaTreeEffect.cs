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
        StartCoroutine(Dis_tree());

    }
    
    IEnumerator Dis_tree()
    {
        if(Data.Instance.gameData.tree_lv == 1)
            yield return new WaitForSeconds(10f);
        else if (Data.Instance.gameData.tree_lv == 2)
            yield return new WaitForSeconds(11f);
        else if (Data.Instance.gameData.tree_lv == 3)
            yield return new WaitForSeconds(12f);
        else if (Data.Instance.gameData.tree_lv == 4)
            yield return new WaitForSeconds(13f);
        else if (Data.Instance.gameData.tree_lv == 5)
            yield return new WaitForSeconds(14f);
        else if (Data.Instance.gameData.tree_lv == 6)
            yield return new WaitForSeconds(15f);
        Manager.manager.sound.treeHeal.Stop();
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
                    if (Data.Instance.gameData.tree_lv == 1)
                        Manager.manager.player.hp++;
                    else if (Data.Instance.gameData.tree_lv == 2)
                        Manager.manager.player.hp++;
                    else if (Data.Instance.gameData.tree_lv == 3)
                        Manager.manager.player.hp += 2;
                    else if (Data.Instance.gameData.tree_lv == 4)
                        Manager.manager.player.hp += 3;
                    else if (Data.Instance.gameData.tree_lv == 5)
                        Manager.manager.player.hp += 4;
                    else if (Data.Instance.gameData.tree_lv == 6)
                        Manager.manager.player.hp += 5;
                    tree_Tmp_CT = tree_CT;
                }
            }
        }
    }
}
