using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_GunGroup : MonoBehaviour
{
    public GameObject group1;
    public GameObject group2;
    public GameObject group3;
    public GameObject group4;
    public GameObject group5;
    public GameObject group6;
    public GameObject group7;
    public GameObject group8;
    public GameObject group9;
    public GameObject group10;
    public GameObject group11;
    public GameObject group12;
    public GameObject group13;
    public GameObject group14;
    public GameObject group15;

    private void OnEnable()
    {
        group1.gameObject.SetActive(false);
        group2.gameObject.SetActive(false);
        group3.gameObject.SetActive(false);
        group4.gameObject.SetActive(false);
        group5.gameObject.SetActive(false);
        group6.gameObject.SetActive(false);
        group7.gameObject.SetActive(false);
        group8.gameObject.SetActive(false);
        group9.gameObject.SetActive(false);
        group10.gameObject.SetActive(false);
        group11.gameObject.SetActive(false);
        group12.gameObject.SetActive(false);
        group13.gameObject.SetActive(false);
        group14.gameObject.SetActive(false);
        group15.gameObject.SetActive(false);

        group1.gameObject.SetActive(true);
        StartCoroutine(nameof(Group2));
        StartCoroutine(nameof(Dis_GunGroup));
    }

    IEnumerator Group2()
    {
        yield return new WaitForSeconds(0.3f);
        group2.gameObject.SetActive(true);
        StartCoroutine(nameof(Group3));
    }

    IEnumerator Group3()
    {
        yield return new WaitForSeconds(0.3f);
        group3.gameObject.SetActive(true);
        StartCoroutine(nameof(Group4));
    }

    IEnumerator Group4()
    {
        yield return new WaitForSeconds(0.3f);
        group4.gameObject.SetActive(true);
        StartCoroutine(nameof(Group5));
    }

    IEnumerator Group5()
    {
        yield return new WaitForSeconds(0.3f);
        group5.gameObject.SetActive(true);
        StartCoroutine(nameof(Group6));
    }

    IEnumerator Group6()
    {
        yield return new WaitForSeconds(0.3f);
        group6.gameObject.SetActive(true);
        StartCoroutine(nameof(Group7));
    }

    IEnumerator Group7()
    {
        yield return new WaitForSeconds(0.3f);
        group7.gameObject.SetActive(true);
        StartCoroutine(nameof(Group8));
    }

    IEnumerator Group8()
    {
        yield return new WaitForSeconds(0.3f);
        group8.gameObject.SetActive(true);
        StartCoroutine(nameof(Group9));
    }

    IEnumerator Group9()
    {
        yield return new WaitForSeconds(0.3f);
        group9.gameObject.SetActive(true);
        StartCoroutine(nameof(Group10));
    }

    IEnumerator Group10()
    {
        yield return new WaitForSeconds(0.3f);
        group10.gameObject.SetActive(true);
        StartCoroutine(nameof(Group11));
    }

    IEnumerator Group11()
    {
        yield return new WaitForSeconds(0.3f);
        group11.gameObject.SetActive(true);
        StartCoroutine(nameof(Group12));
    }

    IEnumerator Group12()
    {
        yield return new WaitForSeconds(0.3f);
        group12.gameObject.SetActive(true);
        StartCoroutine(nameof(Group13));
    }

    IEnumerator Group13()
    {
        yield return new WaitForSeconds(0.3f);
        group13.gameObject.SetActive(true);
        StartCoroutine(nameof(Group14));
    }

    IEnumerator Group14()
    {
        yield return new WaitForSeconds(0.3f);
        group14.gameObject.SetActive(true);
        StartCoroutine(nameof(Group15));
    }

    IEnumerator Group15()
    {
        yield return new WaitForSeconds(0.3f);
        group15.gameObject.SetActive(true);
    }


    IEnumerator Dis_GunGroup()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }
}
