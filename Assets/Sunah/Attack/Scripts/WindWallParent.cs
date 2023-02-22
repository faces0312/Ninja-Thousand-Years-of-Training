using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindWallParent : MonoBehaviour
{
    public WindWallEffect startwindwall;

    public void exe_WindwallStart()
    {
        startwindwall.Exe_WindWallStart();
    }
    // Start is called before the first frame update

    public void Dis_WindWall()
    {
        gameObject.SetActive(false);

    }

}
