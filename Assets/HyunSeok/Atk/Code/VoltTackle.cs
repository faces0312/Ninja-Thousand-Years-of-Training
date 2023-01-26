using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoltTackle : MonoBehaviour
{
    public Player player;
    public Player_Body player_Body;
    private void OnEnable()
    {
        StartCoroutine(Volt());
        player.animator_walk.SetBool("Is_Walk", false);
        player.animator_walk.SetBool("Is_VoltTackle", true);
    }

    IEnumerator Volt()
    {
        player_Body.is_invin = true;
        player.speed = 5;
        yield return new WaitForSeconds(2.6f);
        player.animator_walk.SetBool("Is_VoltTackle", false);
        yield return new WaitForSeconds(0.4f);
        player.speed = 3;
        player_Body.is_invin = false;
        gameObject.SetActive(false);
    }
}
