using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Atk : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Dis_Atk());
    }

    void Update()
    {
        transform.Translate(Vector3.right * 6 * Time.deltaTime);
    }

    IEnumerator Dis_Atk()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}
