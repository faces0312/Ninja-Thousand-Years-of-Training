using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Dis_Fire());
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * 6 * Time.deltaTime);
    }

    IEnumerator Dis_Fire()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}
