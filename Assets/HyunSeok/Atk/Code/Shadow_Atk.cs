using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow_Atk : MonoBehaviour
{
    private void OnEnable()
    {
        //transform.localEulerAngles = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 0, 10 , Space.Self);
        transform.Translate(Vector3.right * 8 * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mob")
        {
            gameObject.SetActive(false);
        }
    }
}
