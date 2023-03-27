using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    int ran_num;//���۽� ���� �������� �����ϱ� ���� ����
    float speed;
    public SpriteRenderer rend;

    public Vector2 moveVector;//�̵� ����

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
        if(Data.Instance.gameData.tornado_lv == 1)
            yield return new WaitForSeconds(6);
        else if (Data.Instance.gameData.tornado_lv == 2)
            yield return new WaitForSeconds(6);
        else if (Data.Instance.gameData.tornado_lv == 3)
            yield return new WaitForSeconds(9);
        else if (Data.Instance.gameData.tornado_lv == 4)
            yield return new WaitForSeconds(9);
        else if (Data.Instance.gameData.tornado_lv == 5)
            yield return new WaitForSeconds(12);
        else if (Data.Instance.gameData.tornado_lv == 6)
            yield return new WaitForSeconds(15);
        gameObject.SetActive(false);
    }
}
