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
    
    public void Electric()//����ġ�� ����
    {
        electric.gameObject.SetActive(true);
    }

    public void Electric_Area()//������ ����
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
