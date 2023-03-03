using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_Cremore_Attack0 : MonoBehaviour
{
    public Redspit_Boss_Cremore cremore;
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject attack4;
    public GameObject attack5;
    public GameObject attack6;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cremore.move_vector, 4f * Time.deltaTime);



        if (((transform.position.x <= cremore.move_vector.x + 0.01f) && (transform.position.x >= cremore.move_vector.x - 0.01f))
            && ((transform.position.y <= cremore.move_vector.y + 0.01f) && (transform.position.y >= cremore.move_vector.y - 0.01f)))
        {
            attack1.transform.position = gameObject.transform.position;
            attack2.transform.position = gameObject.transform.position;
            attack3.transform.position = gameObject.transform.position;
            attack4.transform.position = gameObject.transform.position;
            attack5.transform.position = gameObject.transform.position;
            attack6.transform.position = gameObject.transform.position;

            attack1.gameObject.SetActive(true);
            attack2.gameObject.SetActive(true);
            attack3.gameObject.SetActive(true);
            attack4.gameObject.SetActive(true);
            attack5.gameObject.SetActive(true);
            attack6.gameObject.SetActive(true);

            gameObject.SetActive(false);
        }
    }
}
