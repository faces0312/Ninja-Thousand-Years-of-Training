using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_ArrowRight : MonoBehaviour
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
        rigid.velocity = Manager.manager.player.transform.position;
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
