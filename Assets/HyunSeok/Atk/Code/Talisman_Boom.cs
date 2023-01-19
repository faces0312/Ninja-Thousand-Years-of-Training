using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talisman_Boom : MonoBehaviour
{
    public GameObject talisman;

    public void Dis_Talisman()
    {
        gameObject.SetActive(false);
        talisman.gameObject.SetActive(false);
    }
}
