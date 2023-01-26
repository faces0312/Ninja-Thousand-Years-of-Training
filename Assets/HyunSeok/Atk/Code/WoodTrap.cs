using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodTrap : MonoBehaviour
{
    Vector3 size;
    private void OnEnable()
    {
        //StartCoroutine(Dis_WoodTrap());
        StartCoroutine(SizeUp());
        size = new Vector3(2.5f, 2.5f);
        gameObject.transform.localScale = size;
    }

    IEnumerator SizeUp()
    {
        for(int i=0; i<1000; i++)
        {
            size.x += 0.0015f;
            size.y += 0.0015f;
            gameObject.transform.localScale = size;
            yield return new WaitForSeconds(0.001f);
        }
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }


    /*IEnumerator Dis_WoodTrap()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
    }*/
}
