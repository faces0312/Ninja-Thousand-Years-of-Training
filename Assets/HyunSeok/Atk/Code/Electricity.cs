using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricity : MonoBehaviour
{
    public GameObject electric;
    private void OnEnable()
    {
        electric.gameObject.SetActive(false);
        StartCoroutine(Dis_Electricity());
    }
    
    public void Electric()//±¤¹üÀ§ °ø°Ý
    {
        electric.gameObject.SetActive(true);
    }

    IEnumerator Dis_Electricity()
    {
        yield return new WaitForSeconds(3f);
        electric.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
