using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricity : MonoBehaviour
{
    public GameObject electric;
    public GameObject electric_Area;

    private void OnEnable()
    {
        electric.gameObject.SetActive(false);
        electric_Area.gameObject.SetActive(false);
    }
    
    public void Electric()//내려치는 공격
    {
        electric.gameObject.SetActive(true);
    }

    public void Electric_Area()//광범위 공격
    {
        electric.gameObject.SetActive(false);
        electric_Area.gameObject.SetActive(true);
    }

    public void Dis_Electricity()
    {
        electric.gameObject.SetActive(false);
        electric_Area.gameObject.SetActive(false);
        gameObject.gameObject.SetActive(false);
    }

}
