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

    /*public GameObject attack;

    public float speed;
    public Rigidbody2D rigid;
    Vector3 lastVelocity;

    private void Start()
    {
        //rigid = GetComponent<Rigidbody2D>();
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
        attack.gameObject.transform.position = gameObject.transform.position;
        lastVelocity = rigid.velocity;
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.layer == 11)
        {
            speed = lastVelocity.magnitude;
            var dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

            rigid.velocity = dir * Mathf.Max(speed, 0f);
        }
    }

    IEnumerator Dis_MachineGun()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
    }*/

    /*private void OnEnable()
    {
        StartCoroutine(Dis_MachineGun());
    }

    IEnumerator Dis_MachineGun()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
    }*/

    /*public float speed;
    *//*public Rigidbody2D rigid;
    Vector3 lastVelocity;*/

    public Vector3 moveVector;//¿Ãµø ∫§≈Õ

    private void OnEnable()
    {
        StartCoroutine(Dis_MachineGun());
        /*speed = 0.05f;
        rigid.velocity = Manager.manager.player.transform.position.normalized;
        rigid.velocity = rigid.velocity * speed;*/
        moveVector = Vector3.right;
    }

    private void FixedUpdate()
    {
        transform.Translate(moveVector * 5f * Time.deltaTime);
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

    IEnumerator Dis_MachineGun()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}
