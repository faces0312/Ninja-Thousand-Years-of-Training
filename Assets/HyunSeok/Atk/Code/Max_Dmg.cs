using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Max_Dmg : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Dis_MaxDmg());
    }

    IEnumerator Dis_MaxDmg()
    {
        yield return new WaitForSeconds(0.3f);
        Manager.manager.objectManager.player_wall.gameObject.SetActive(true);
        Manager.manager.objectManager.mob_wall.transform.position = Manager.manager.objectManager.player.transform.position;
        Manager.manager.objectManager.mob_wall.gameObject.SetActive(true);
        Manager.manager.objectManager.Boss_General();
        gameObject.SetActive(false);
    }
}
