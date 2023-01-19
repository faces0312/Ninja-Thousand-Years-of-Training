using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting_Line : MonoBehaviour
{
    public Player player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0,-0.15f,0);
    }
}
