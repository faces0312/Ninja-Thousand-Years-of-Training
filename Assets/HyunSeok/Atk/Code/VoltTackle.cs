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
        if(Data.Instance.gameData.voltTackle_lv == 1)
            yield return new WaitForSeconds(3f);
        else if (Data.Instance.gameData.voltTackle_lv == 2)
            yield return new WaitForSeconds(3f);
        else if (Data.Instance.gameData.voltTackle_lv == 3)
            yield return new WaitForSeconds(3.5f);
        else if (Data.Instance.gameData.voltTackle_lv == 4)
            yield return new WaitForSeconds(3.5f);
        else if (Data.Instance.gameData.voltTackle_lv == 5)
            yield return new WaitForSeconds(4f);
        else if (Data.Instance.gameData.voltTackle_lv == 6)
            yield return new WaitForSeconds(4f);

        player.animator_walk.SetBool("Is_VoltTackle", false);
        yield return new WaitForSeconds(0.4f);
        player.speed = 3;
        player_Body.is_invin = false;
        gameObject.SetActive(false);
    }
}
