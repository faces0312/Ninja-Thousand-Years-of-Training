using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
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

    private void FixedUpdate()
    {
        transform.Translate(moveVector * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bounce" || collision.gameObject.layer == 7)
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
        if(Data.Instance.gameData.boomerang_lv == 1)
            yield return new WaitForSeconds(5);
        else if (Data.Instance.gameData.boomerang_lv == 2)
            yield return new WaitForSeconds(6);
        else if (Data.Instance.gameData.boomerang_lv == 3)
            yield return new WaitForSeconds(6);
        else if (Data.Instance.gameData.boomerang_lv == 4)
            yield return new WaitForSeconds(8);
        else if (Data.Instance.gameData.boomerang_lv == 5)
            yield return new WaitForSeconds(10);
        else if (Data.Instance.gameData.boomerang_lv == 6)
            yield return new WaitForSeconds(15);
        gameObject.SetActive(false);
    }
}
