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
    public UnityEvent OnBegin, OnDone;
    
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();//�� ��ũ��Ʈ ������Ʈ���� rigidbody�� ������


    }

    private void OnEnable()
    {
        x = 1f;
        y = 1f;
        windwall_CT = 1f;   //�̰Թ���????????????????????????????????????????????????
        windwall_CT = windwall_CT;
        gameObject.transform.localScale = new Vector3(x, y);
        StartCoroutine(Dis_WindWall());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    IEnumerator Dis_WindWall()
    {
        for(int i=0; i<100; i++)
        {
            x += 0.05f;
            y += 0.05f;
            gameObject.transform.localScale = new Vector3(x, y);
            yield return new WaitForSeconds(0.01f); //Ư���ð� �ڿ� �Լ� ȣ��

        }
        yield return new WaitForSeconds(1f); //delay �ֱ�
        gameObject.SetActive(false);

    }

    IEnumerator KnockBack(Vector3 reactVec)
    {// ���� �˹��� player���� windwall�� �и��°Ű���
        yield return new WaitForSeconds(delay);
        if (Manager.manager.mob.hp > 0)
        {
            reactVec = reactVec.normalized; //���ʹ� �������� ��ġ�� ��� �ٲ� �� ���ϵǰ�
            
            rb2d.AddForce(reactVec * 3, ForceMode2D.Impulse);
            
        }

    }

  /*  IEnumerator Reset()
    {
        yield return new WaitForSeconds(delay); //
        rb2d.velocity = Vector3.zero; //���� ������������
    }*/
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
    }

}
