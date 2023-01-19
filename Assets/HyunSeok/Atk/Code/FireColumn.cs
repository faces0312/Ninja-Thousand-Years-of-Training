using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireColumn : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Dis_FireColumn());
    }
    
    IEnumerator Dis_FireColumn()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}
