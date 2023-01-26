using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msaTreeEffect : MonoBehaviour
{
    //1초에 1hp 회복
    //트리거 내에 있을때 1초의 쿨타임이 줄어들게
    //1초의 쿨타임 전부 줄어들었을때 player의 체력이 최대가 아니라면 체력 +1
    //10초 뒤 나무 오브젝트 사라짐

    // Start is called before the first frame update

    public Player player;
    public int hp = 10;
    public int time = 10;
    //aadadaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           
            if (hp == 10)  //이건if(collision.gameObject.tag == "Tree")로 해서
                           //player코드에 있어야할거같음
            {
                hp += 0;
            }
            else
            {
                hp += 1;
            }
        }
    }
}
