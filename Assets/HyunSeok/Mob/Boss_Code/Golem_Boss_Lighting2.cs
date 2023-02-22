using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Boss_Lighting2 : MonoBehaviour
{
    public Golem_Boss_Lighting golem_;

    public void Dis_Lighting()
    {
        golem_.lighting_Range.enabled = false;
        golem_.gameObject.SetActive(false);
    }
}
