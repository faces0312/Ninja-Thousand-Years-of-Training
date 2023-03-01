using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_MachineGun : MonoBehaviour
{
    /*public Vector2 moveVector;//¿Ãµø ∫§≈Õ

    private void OnEnable()
    {
        moveVector = Vector3.right;
        StartCoroutine(Dis_MachineGun());

    }

    IEnumerator Dis_MachineGun()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        //transform.Rotate(0, 0, 10 , Space.Self);
        transform.Translate(moveVector * 5f * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            moveVector = Vector2.Reflect(moveVector, collision.contacts[0].normal);
            moveVector = moveVector.normalized;
        }
    }*/

    public float speed;
    public Rigidbody2D rigid;
    Vector3 lastVelocity;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        speed = 3f;
        rigid.velocity = Manager.manager.player.transform.position;
        rigid.velocity = rigid.velocity.normalized * speed;
        StartCoroutine(Dis_MachineGun());
    }

    private void Update()
    {
        lastVelocity = rigid.velocity;
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        speed = lastVelocity.magnitude;
        var dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

        rigid.velocity = dir * Mathf.Max(speed, 0f);
    }

    IEnumerator Dis_MachineGun()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
    }
}
