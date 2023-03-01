using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redspit_Boss_Arrow : MonoBehaviour
{
    public GameObject main_Arrow;

    public GameObject sub_Arrow1;
    public GameObject sub_Arrow2;
    public GameObject sub_Arrow3;
    public GameObject sub_Arrow4;
    public GameObject sub_Arrow5;
    public GameObject sub_Arrow6;
    public GameObject sub_Arrow7;
    public GameObject sub_Arrow8;
    public GameObject sub_Arrow9;
    public GameObject sub_Arrow10;
    public GameObject sub_Arrow11;
    public GameObject sub_Arrow12;
    public GameObject sub_Arrow13;
    public GameObject sub_Arrow14;
    public GameObject sub_Arrow15;

    public GameObject up1;
    public GameObject up2;
    public GameObject up3;
    public GameObject up4;
    public GameObject up5;
    public GameObject up6;
    public GameObject up7;
    public GameObject up8;
    public GameObject up9;
    public GameObject up10;
    public GameObject up11;
    public GameObject up12;
    public GameObject up13;
    public GameObject up14;
    public GameObject up15;

    public GameObject down1;
    public GameObject down2;
    public GameObject down3;
    public GameObject down4;
    public GameObject down5;
    public GameObject down6;
    public GameObject down7;
    public GameObject down8;
    public GameObject down9;
    public GameObject down10;
    public GameObject down11;
    public GameObject down12;
    public GameObject down13;
    public GameObject down14;
    public GameObject down15;


    private void OnEnable()
    {
        main_Arrow.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow1.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow2.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow3.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow4.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow5.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow6.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow7.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow8.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow9.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow10.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow11.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow12.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow13.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow14.gameObject.transform.position = gameObject.transform.position;
        sub_Arrow15.gameObject.transform.position = gameObject.transform.position;

        up1.gameObject.transform.position = sub_Arrow1.transform.position;
        down1.gameObject.transform.position = sub_Arrow1.transform.position;
        up2.gameObject.transform.position = sub_Arrow2.transform.position;
        down2.gameObject.transform.position = sub_Arrow2.transform.position;
        up3.gameObject.transform.position = sub_Arrow3.transform.position;
        down3.gameObject.transform.position = sub_Arrow3.transform.position;
        up4.gameObject.transform.position = sub_Arrow4.transform.position;
        down4.gameObject.transform.position = sub_Arrow4.transform.position;
        up5.gameObject.transform.position = sub_Arrow5.transform.position;
        down5.gameObject.transform.position = sub_Arrow5.transform.position;
        up6.gameObject.transform.position = sub_Arrow6.transform.position;
        down6.gameObject.transform.position = sub_Arrow6.transform.position;
        up7.gameObject.transform.position = sub_Arrow7.transform.position;
        down7.gameObject.transform.position = sub_Arrow7.transform.position;
        up8.gameObject.transform.position = sub_Arrow8.transform.position;
        down8.gameObject.transform.position = sub_Arrow8.transform.position;
        up9.gameObject.transform.position = sub_Arrow9.transform.position;
        down9.gameObject.transform.position = sub_Arrow9.transform.position;
        up10.gameObject.transform.position = sub_Arrow10.transform.position;
        down10.gameObject.transform.position = sub_Arrow10.transform.position;
        up11.gameObject.transform.position = sub_Arrow11.transform.position;
        down11.gameObject.transform.position = sub_Arrow11.transform.position;
        up12.gameObject.transform.position = sub_Arrow12.transform.position;
        down12.gameObject.transform.position = sub_Arrow12.transform.position;
        up13.gameObject.transform.position = sub_Arrow13.transform.position;
        down13.gameObject.transform.position = sub_Arrow13.transform.position;
        up14.gameObject.transform.position = sub_Arrow14.transform.position;
        down14.gameObject.transform.position = sub_Arrow14.transform.position;
        up15.gameObject.transform.position = sub_Arrow15.transform.position;
        down15.gameObject.transform.position = sub_Arrow15.transform.position;


        sub_Arrow1.gameObject.SetActive(false);
        sub_Arrow2.gameObject.SetActive(false);
        sub_Arrow3.gameObject.SetActive(false);
        sub_Arrow4.gameObject.SetActive(false);
        sub_Arrow5.gameObject.SetActive(false);
        sub_Arrow6.gameObject.SetActive(false);
        sub_Arrow7.gameObject.SetActive(false);
        sub_Arrow8.gameObject.SetActive(false);
        sub_Arrow9.gameObject.SetActive(false);
        sub_Arrow10.gameObject.SetActive(false);
        sub_Arrow11.gameObject.SetActive(false);
        sub_Arrow12.gameObject.SetActive(false);
        sub_Arrow13.gameObject.SetActive(false);
        sub_Arrow14.gameObject.SetActive(false);
        sub_Arrow15.gameObject.SetActive(false);

        StartCoroutine(Sub_Arrow());
        StartCoroutine(Dis_Arrow());
    }

    IEnumerator Dis_Arrow()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
    }

    IEnumerator Sub_Arrow()
    {
        yield return new WaitForSeconds(0.3f);
        sub_Arrow1.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow1.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow2.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow2.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow3.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow3.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow4.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow4.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow5.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow5.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow6.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow6.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow7.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow7.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow8.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow8.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow9.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow9.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow10.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow10.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow11.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow11.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow12.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow12.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow13.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow13.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow14.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow14.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        sub_Arrow15.gameObject.transform.position = main_Arrow.transform.position;
        sub_Arrow15.gameObject.SetActive(true);
    }
}
