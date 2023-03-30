using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager2 : MonoBehaviour
{

    public AudioSource treeHeal;
    public AudioSource bossLightning;
    public AudioSource bossWarning;
    public AudioSource bossLaser;
    public AudioSource boomerang;
    public AudioSource voltTackle;
    public AudioSource tailsmanBomb;
    public AudioSource shock;
    public AudioSource killEnemy;
    public AudioSource wind;
    public AudioSource electricity;
    public AudioSource tornado;
    public AudioSource normalAttack;
    public AudioSource fireColumn;
    public AudioSource launchFire;
    public void TreeHeal()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            treeHeal.Play();
        }
        else
            return;
    }

    public void BossLightning()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            bossLightning.Play();
        }
        else
            return;
    }

    public void BossWarning()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            bossWarning.Play();
        }
        else
            return;
    }

    public void BossLaser()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            bossLaser.Play();
        }
        else
            return;
    }

    public void Boomerang()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            boomerang.Play();
        }
        else
            return;
    }
    public void VoltTackle ()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            voltTackle.Play();
        }
        else
            return;
    }
    public void TailsmanBomb()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            tailsmanBomb.Play();
        }
        else
            return;
    }
    public void Shock()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            shock.Play();
        }
        else
            return;
    }
    public void KillEnemy()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            killEnemy.Play();
        }
        else
            return;
    }

    public void Wind()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            wind.Play();
        }
        else
            return;
    }

    public void Electricity()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            electricity.Play();
        }
        else
            return;
    }
    public void Tornado()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
           tornado.Play();
        }
        else
            return;
    }
    public void NormalAttack()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            normalAttack.Play();
        }
        else
            return;
    }
    public void FireColumn()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            fireColumn.Play();
        }
        else
            return;
    }


    public void LaunchFire()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            launchFire.Play();
        }
        else
            return;
    }



}
