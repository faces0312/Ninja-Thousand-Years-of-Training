using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_MachineGun_Trigger : MonoBehaviour
{
    public Redspit_Boss_MachineGun machineGun;

    public float speed;
    public Rigidbody2D rigid;
    Vector3 lastVelocity;

    private void OnEnable()
    {
        StartCoroutine(Dis_MachineGun());
        speed = 0.05f;
        rigid.velocity = Manager.manager.player.transform.position.normalized;
        rigid.velocity = rigid.velocity * speed;
    }

    private void FixedUpdate()
    {
        machineGun.gameObject.transform.position = gameObject.transform.position;
        lastVelocity = rigid.velocity;
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 11)
        {
            //speed = lastVelocity.magnitude;
            var dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

            rigid.velocity = dir * Mathf.Max(speed, 0f);
        }
    }

    IEnumerator Dis_MachineGun()
    {
        yield return new WaitForSeconds(7f);
        machineGun.gameObject.SetActive(false);
    }
}
