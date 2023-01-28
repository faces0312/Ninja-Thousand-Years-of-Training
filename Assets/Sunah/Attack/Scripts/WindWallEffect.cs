using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindWallEffect : MonoBehaviour
{

    public float x;
    public float y;

    public float windwall_CT;
    public float windwall_Tmp_CT;

    private void OnEnable()
    {
        x = 1f;
        y = 1f;
        gameObject.transform.localScale = new Vector3(x, y);
        StartCoroutine(Dis_WindWall());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    IEnumerator Dis_WindWall()
    {
        for(int i=0; i<100; i++)
        {
            x += 0.05f;
            y += 0.05f;
            gameObject.transform.localScale = new Vector3(x, y);
            yield return new WaitForSeconds(0.01f); //특정시간 뒤에 함수 호출

        }
        yield return new WaitForSeconds(1f); //delay 주기
        gameObject.SetActive(false);

    }
    private void OnTriggerStay2D(Collider2D collision)  
    { //오브젝트간 충돌이 일어나는 동안 지속적으로 호출되는 함수.  닿는 동안 hp감ㅁ소하나?
        if (collision.gameObject.tag == "Mob")
        { //windwall이 mob과 닿았을때 몹이 움직이던 방향의 반대방향ㅇ로 튕겨내고 몹은 hp 감소 & 다시 player에게 온다. 
            if (windwall_Tmp_CT > 0) //windwall 사라지기전까지 쿨타임
                windwall_Tmp_CT -= Time.deltaTime;
            else
            { //옵이 안죽었을때 이거 Mob1_Body에서 해서 안해도될듯    // 크기가 바뀌는 애들은 컬리젼을 어떻게 설정하지??????????????????????????????????????????몹 왜안죽음?
                /* if (Manager.manager.mob.hp > 0 )
                 {   ////////////////////더이상 졸려서 진행이안됨.
                     Manager.manager.mob.hp--;
                     windwall_Tmp_CT = windwall_CT;
                 }*/

            }

        }
    }

}
