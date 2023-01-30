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
    private float strength = 16; //넉백의 강도
    private float delay = 0.15f; //적이 다시 움직일 수 있도록 하는 지연시간
    public Vector2 MobVector;

/*    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();//이 스크립트 오브젝트에서 rigidbody를 가져옴


    }
*/
    private void OnEnable()
    {
        x = 0f;
        y = 0f;
        windwall_CT = 1f;   //이게뭐지????????????????????????????????????????????????
        windwall_CT = windwall_CT;
        gameObject.transform.localScale = new Vector3(x, y);
     

        StartCoroutine(Dis_WindWall());
       
    }
 
    IEnumerator Dis_WindWall()
    {  //windwall 크기 확대
        for(int i=0; i<50; i++)
        {
            x += 0.05f;
            y += 0.05f;
            gameObject.transform.localScale = new Vector3(x, y);
            yield return new WaitForSeconds(0.01f); //특정시간 뒤에 함수 호출

        }
        yield return new WaitForSeconds(1f); //delay 주기
        gameObject.SetActive(false);

    }
    // collision 쓸때는 rigidbody에 dynamic으로 설정. 그러면 튕김. kinematic쓰면 통과됨.
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
        {// 넉백에 ㄴ자도 안됨 다시구현
            yield return new WaitForSeconds(delay);
            if (Manager.manager.mob.hp > 0)
            {
                reactVec = reactVec.normalized; //벡터는 떄에따라 수치가 계속 바뀌어서 값 통일되게

                rb2d.AddForce(reactVec * 3, ForceMode2D.Impulse);

            }

        }

      *//*  IEnumerator Reset()
        {
            yield return new WaitForSeconds(delay); //
            rb2d.velocity = Vector3.zero; //적이 움직이지않음
        }*//*
        private void OnTriggerStay2D(Collider2D collision)  
        { //오브젝트간 충돌이 일어나는 동안 지속적으로 호출되는 함수.  닿는 동안 hp감ㅁ소하나?
            if (collision.gameObject.tag == "Mob")
            { //windwall이 mob과 닿았을때 몹이 움직이던 방향의 반대방향ㅇ로 튕겨내고 몹은 hp 감소 & 다시 player에게 온다. 
                if (windwall_Tmp_CT > 0)
                {//windwall 사라지기전까지 쿨타임
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
