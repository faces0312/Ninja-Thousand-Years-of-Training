using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_Cremore_Attack3 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigid;
    Vector3 lastVelocity;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        speed = 2f;
        rigid.velocity = new Vector2(-1, 1);
        rigid.velocity = rigid.velocity.normalized * speed;
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
}
