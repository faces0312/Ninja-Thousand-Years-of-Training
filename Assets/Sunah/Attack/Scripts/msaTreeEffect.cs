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

    public Player player;
    public int hp = 10;
    public int time = 10;
    //aadadaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           
            if (hp == 10)  //�̰�if(collision.gameObject.tag == "Tree")�� �ؼ�
                           //player�ڵ忡 �־���ҰŰ���
            {
                hp += 0;
            }
            else
            {
                hp += 1;
            }
        }
    }
}
