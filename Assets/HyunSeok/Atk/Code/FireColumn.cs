using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireColumn : MonoBehaviour
{
    public GameObject dmg_area;
    private void OnEnable()
    {
        dmg_area.gameObject.SetActive(false);
        StartCoroutine(Dis_FireColumn());
        StartCoroutine(Dmg_on());
    }
    
    IEnumerator Dis_FireColumn()
    {
        yield return new WaitForSeconds(1.5f);
        dmg_area.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
    IEnumerator Dmg_on()
    {
        yield return new WaitForSeconds(0.1f);
        dmg_area.gameObject.SetActive(true);
    }
}
