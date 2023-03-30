using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public AudioSource button_Click;
    public AudioSource open_Window;
    public AudioSource upgrade_Success;

    public void Button_Click()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            button_Click.Play();
        }
        else
            return;
    }

    public void Open_Window()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            open_Window.Play();
        }
        else
            return;
    }

    public void Upgrade_Success()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            upgrade_Success.Play();
        }
        else
            return;
    }
}
