using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Laser : MonoBehaviour
{
    bool is_rotate;
    private void OnEnable()
    {
        is_rotate = false;
        StartCoroutine(nameof(Laser));
        StartCoroutine(nameof(Dis_Laser));
    }

    private void Update()
    {
        if(is_rotate == true)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
        }
    }

    IEnumerator Laser()
    {
        yield return new WaitForSeconds(0.5f);
        is_rotate = true;
    }

    IEnumerator Dis_Laser()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}
