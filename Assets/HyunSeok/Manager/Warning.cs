using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    private void OnEnable()
    {
        Manager.manager.sound.BossWarning();
    }
}
