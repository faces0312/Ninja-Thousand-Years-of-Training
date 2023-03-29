using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public AudioSource button_Click;

    public void Button_Click()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            button_Click.Play();
        }
        else
            return;
    }
}
