using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Wind_Go());
    }
    //dsafsadlkfjaslkfjasdflkj

    IEnumerator Wind_Go()
    {
        for(int i=0; i<100; i++)
        {
            //transform.position = Vector3.Slerp(gameObject.transform.position, Vector3.right * Time.deltaTime, 0.1f);
            yield return new WaitForSeconds(0.01f);
        }
        gameObject.SetActive(false);
    }
}
