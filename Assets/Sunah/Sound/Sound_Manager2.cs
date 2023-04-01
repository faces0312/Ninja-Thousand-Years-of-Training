using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager2 : MonoBehaviour
{
    public AudioSource bossLightning;
    public AudioSource bossWarning;
    public AudioSource bossLaser;
    public AudioSource killEnemy;
    public AudioSource normalAttack;
    public AudioSource boomerang;
    public AudioSource fire;
    public AudioSource[] talismanBomb;
    public AudioSource fireColumn;
    public AudioSource wind;
    public AudioSource treeHeal;
    public AudioSource tornado;
    public AudioSource voltTackle;
    public AudioSource electricity;
    
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
    public void TalismanBomb()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            for (int i = 0; i < 35; i++)
            {
                if (Manager.manager.talisman_is[i] == true)
                {
                    talismanBomb[i].Play();
                    Manager.manager.talisman_cnt = i + 1;
                }
            }

            for(int i=0;i<36;i++)
                Manager.manager.talisman_is[i] = false;

            Manager.manager.talisman_is[Manager.manager.talisman_cnt] = true;
        }
        else
            return;
    }
    public void KillEnemy()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            killEnemy.PlayOneShot(killEnemy.clip);
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


    public void Fire()
    {
        if (Data.Instance.gameData.is_effect_sound_reverse == false)
        {
            fire.Play();
        }
        else
            return;
    }



}
