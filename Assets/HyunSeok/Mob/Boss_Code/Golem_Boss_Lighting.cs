using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Boss_Lighting : MonoBehaviour
{
    public GameObject lighting;
    public CapsuleCollider2D lighting_Range;

    // Start is called before the first frame update
    void OnEnable()
    {
        lighting.gameObject.SetActive(false);
        lighting_Range.enabled = false;
        StartCoroutine(Lighting());
    }

    IEnumerator Lighting()
    {
        yield return new WaitForSeconds(0.8f);
        lighting.gameObject.SetActive(true);
        lighting_Range.enabled = true;
    }
}
