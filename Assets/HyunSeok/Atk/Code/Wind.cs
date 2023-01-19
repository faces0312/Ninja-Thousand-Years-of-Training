using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public Player player;
    public GameObject wind_Location;
    public float speed;

    private void Update()
    {
        /*if (player.transform.localScale.x < 0)
        {
            Vector3 scale = new Vector3(-0.7f,0.7f,1);
            transform.localScale = scale;
        }
        else if (player.transform.localScale.x > 0)
        {
            Vector3 scale = new Vector3(0.7f, 0.7f, 1);
            transform.localScale = scale;
        }*/


        transform.RotateAround(wind_Location.transform.position, Vector3.forward, Time.deltaTime * speed);
    }


}
