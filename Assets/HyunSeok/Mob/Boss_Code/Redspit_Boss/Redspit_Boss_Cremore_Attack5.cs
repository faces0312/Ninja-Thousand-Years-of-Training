using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_Cremore_Attack5 : MonoBehaviour
{
    public Vector3 moveVector;//¿Ãµø ∫§≈Õ

    private void OnEnable()
    {
        /*speed = 0.05f;
        rigid.velocity = Manager.manager.player.transform.position.normalized;
        rigid.velocity = rigid.velocity * speed;*/
        moveVector = Vector3.right;
    }

    private void FixedUpdate()
    {
        transform.Translate(moveVector * 2.8f * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 11)
        {
            //speed = lastVelocity.magnitude;
            //moveVector = Vector2.Reflect(moveVector.normalized, coll.contacts[0].normal).normalized;
            Vector2 start = new Vector2(transform.position.x, transform.position.y);
            Vector2 fin = start - coll.contacts[0].point;
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 45);
            //rigid.velocity = dir * Mathf.Max(speed, 0f);
        }
    }
}
