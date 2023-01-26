using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    int ran_num;//시작시 랜덤 방향으로 진행하기 위한 변수
    float speed;
    public SpriteRenderer rend;

    public Vector2 moveVector;//이동 벡터

    private void Start()
    {
        speed = 5f;
    }
    private void OnEnable()
    {
        ran_num = Random.Range(0, 360);
        moveVector = new Vector2(Mathf.Cos(ran_num), Mathf.Sin(ran_num));
        if (moveVector.x > 0)
            rend.flipX = true;
        else
            rend.flipX = false;

        StartCoroutine(Dis_Tornado());
    }

    private void Update()
    {
        transform.Translate(moveVector * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bounce")
        {
            moveVector = Vector2.Reflect(moveVector, collision.contacts[0].normal);
            if (moveVector.x > 0)
                rend.flipX = true;
            else
                rend.flipX = false;
        }
    }

    IEnumerator Dis_Tornado()
    {
        yield return new WaitForSeconds(10);
        gameObject.SetActive(false);
    }
}
