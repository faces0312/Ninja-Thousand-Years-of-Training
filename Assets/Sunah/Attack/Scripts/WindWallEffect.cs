using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WindWallEffect : MonoBehaviour
{

    public float x;
    public float y;

    public float windwall_CT;
    public float windwall_Tmp_CT;

    private Rigidbody2D rb2d;
    private float strength = 16; //�˹��� ����
    private float delay = 0.15f; //���� �ٽ� ������ �� �ֵ��� �ϴ� �����ð�
    public Vector2 MobVector;

/*    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();//�� ��ũ��Ʈ ������Ʈ���� rigidbody�� ������


    }
*/
    private void OnEnable()
    {
        x = 0f;
        y = 0f;
        windwall_CT = 1f;   //�̰Թ���????????????????????????????????????????????????
        windwall_CT = windwall_CT;
        gameObject.transform.localScale = new Vector3(x, y);
     

        StartCoroutine(Dis_WindWall());
       
    }
 
    IEnumerator Dis_WindWall()
    {  //windwall ũ�� Ȯ��
        for(int i=0; i<50; i++)
        {
            x += 0.05f;
            y += 0.05f;
            gameObject.transform.localScale = new Vector3(x, y);
            yield return new WaitForSeconds(0.01f); //Ư���ð� �ڿ� �Լ� ȣ��

        }
        yield return new WaitForSeconds(1f); //delay �ֱ�
        gameObject.SetActive(false);

    }
    // collision ������ rigidbody�� dynamic���� ����. �׷��� ƨ��. kinematic���� �����.
    private void OnCollisionStay2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Mob")
        {
            //MobVector = Vector2.Reflect(gameObject.transform.position, collision.contacts[0].normal);
            Vector2 direction = (collision.gameObject.transform.position - this.gameObject.transform.position).normalized;
            MobVector = direction;
            //new Vector2(collision.gameObject.transform.position - this.gameObject.transform.position).normalized;
            //StartCoroutine(MoveMob(collision.gameObject));
            collision.gameObject.transform.parent.Translate(MobVector * 3f * Time.deltaTime);
        }
    }

    IEnumerator MoveMob(GameObject mob)
    {
        for (int i = 0; i < 1000; i++)
        {
            mob.gameObject.transform.Translate(MobVector*7f*Time.deltaTime);
            yield return new WaitForSeconds(0.001f);
        }
    }
    /*
        IEnumerator KnockBack(Vector3 reactVec)
        {// �˹鿡 ���ڵ� �ȵ� �ٽñ���
            yield return new WaitForSeconds(delay);
            if (Manager.manager.mob.hp > 0)
            {
                reactVec = reactVec.normalized; //���ʹ� �������� ��ġ�� ��� �ٲ� �� ���ϵǰ�

                rb2d.AddForce(reactVec * 3, ForceMode2D.Impulse);

            }

        }

      *//*  IEnumerator Reset()
        {
            yield return new WaitForSeconds(delay); //
            rb2d.velocity = Vector3.zero; //���� ������������
        }*//*
        private void OnTriggerStay2D(Collider2D collision)  
        { //������Ʈ�� �浹�� �Ͼ�� ���� ���������� ȣ��Ǵ� �Լ�.  ��� ���� hp�������ϳ�?
            if (collision.gameObject.tag == "Mob")
            { //windwall�� mob�� ������� ���� �����̴� ������ �ݴ���⤷�� ƨ�ܳ��� ���� hp ���� & �ٽ� player���� �´�. 
                if (windwall_Tmp_CT > 0)
                {//windwall ������������� ��Ÿ��
                    windwall_Tmp_CT -= Time.deltaTime;
                    Vector3 reactVec = transform.position - collision.transform.position;
                    StartCoroutine(KnockBack(reactVec));
                }
                else
                {


                }

            }
        }*/

}
