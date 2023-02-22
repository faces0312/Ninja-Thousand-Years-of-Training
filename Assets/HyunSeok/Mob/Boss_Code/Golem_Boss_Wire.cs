using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Boss_Wire : MonoBehaviour
{
    public GameObject wire1;
    public GameObject wire2;
    public GameObject wire3;
    public GameObject wire4;
    public GameObject wire5;
    public GameObject wire6;
    public GameObject wire7;
    public GameObject wire8;

    private void OnEnable()
    {
        wire1.gameObject.SetActive(true);
        wire2.gameObject.SetActive(true);
        wire3.gameObject.SetActive(true);
        wire4.gameObject.SetActive(true);
        wire5.gameObject.SetActive(true);
        wire6.gameObject.SetActive(true);
        wire7.gameObject.SetActive(true);
        wire8.gameObject.SetActive(true);

        StartCoroutine(Wire1());
    }

    IEnumerator Wire1()
    {
        for(int i=0;i<100;i++)
        {
            if (i == 15)
                StartCoroutine(Wire2());
            wire1.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire1.transform.localScale = new Vector3(wire1.transform.localScale.x, (wire1.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Wire2()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Wire3());
            wire2.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire2.transform.localScale = new Vector3(wire2.transform.localScale.x, (wire2.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Wire3()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Wire4());
            wire3.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire3.transform.localScale = new Vector3(wire3.transform.localScale.x, (wire3.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Wire4()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Wire5());
            wire4.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire4.transform.localScale = new Vector3(wire4.transform.localScale.x, (wire4.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Wire5()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Wire6());
            wire5.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire5.transform.localScale = new Vector3(wire5.transform.localScale.x, (wire5.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Wire6()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Wire7());
            wire6.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire6.transform.localScale = new Vector3(wire6.transform.localScale.x, (wire6.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Wire7()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Wire8());
            wire7.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire7.transform.localScale = new Vector3(wire7.transform.localScale.x, (wire7.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Wire8()
    {
        for (int i = 0; i < 100; i++)
        {
            wire8.transform.Translate(Vector3.right * Time.deltaTime * 2);
            wire8.transform.localScale = new Vector3(wire8.transform.localScale.x, (wire8.transform.localScale.y + 0.05f));
            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(Back_Wire8());
    }

    IEnumerator Back_Wire8()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Back_Wire7());
            wire8.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire8.transform.localScale = new Vector3(wire8.transform.localScale.x, (wire8.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }

        wire8.gameObject.SetActive(false);
    }

    IEnumerator Back_Wire7()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Back_Wire6());
            wire7.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire7.transform.localScale = new Vector3(wire7.transform.localScale.x, (wire7.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
        wire7.gameObject.SetActive(false);
    }

    IEnumerator Back_Wire6()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Back_Wire5());
            wire6.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire6.transform.localScale = new Vector3(wire6.transform.localScale.x, (wire6.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
        wire6.gameObject.SetActive(false);
    }

    IEnumerator Back_Wire5()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Back_Wire4());
            wire5.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire5.transform.localScale = new Vector3(wire5.transform.localScale.x, (wire5.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
        wire5.gameObject.SetActive(false);
    }

    IEnumerator Back_Wire4()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Back_Wire3());
            wire4.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire4.transform.localScale = new Vector3(wire4.transform.localScale.x, (wire4.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
        wire4.gameObject.SetActive(false);
    }

    IEnumerator Back_Wire3()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Back_Wire2());
            wire3.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire3.transform.localScale = new Vector3(wire3.transform.localScale.x, (wire3.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
        wire3.gameObject.SetActive(false);
    }

    IEnumerator Back_Wire2()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 15)
                StartCoroutine(Back_Wire1());
            wire2.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire2.transform.localScale = new Vector3(wire2.transform.localScale.x, (wire2.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
        wire2.gameObject.SetActive(false);
    }

    IEnumerator Back_Wire1()
    {
        for (int i = 0; i < 100; i++)
        {
            wire1.transform.Translate(Vector3.left * Time.deltaTime * 2);
            wire1.transform.localScale = new Vector3(wire1.transform.localScale.x, (wire1.transform.localScale.y - 0.05f));
            yield return new WaitForSeconds(0.01f);
        }
        wire1.gameObject.SetActive(false);
    }
}
