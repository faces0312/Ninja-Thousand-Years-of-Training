using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float hp_max;
    public float hp;
    public GameObject hpbar;
    public GameObject hpbar_Fill;
    [SerializeField]
    private Joy_Stick joy_Stick;

    public ObjectManager objectManager;
    public Animator animator_walk; // 걷기

    public float speed;

    public ShadowPartner shadowPartner1;
    public ShadowPartner shadowPartner2;
    public GameObject shadowPartner1_Loca;
    public GameObject shadowPartner2_Loca;
    private float shadowPartner_speed = 2.8f;

    //볼트 태클
    //public Animator animator_voltTackle; // 걷기
    public GameObject volttackle;
    public float volttackle_CT;
    private float volttackle_Tmp_CT;

    public SpriteRenderer rend;

    public Player_Body player_Body;
    // Start is called before the first frame update
    void Start()
    {
        animator_walk = GetComponent<Animator>();
        //animator_voltTackle = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();

       
        hp_max = Data.Instance.gameData.player_hp;
        hp = hp_max;
        speed = 2;

        //hpbar.value = (float)hp / (float)hp_max;

        volttackle_CT = 23f;
        volttackle_Tmp_CT = volttackle_CT;
    }
  /*  private void OnEnable()
    {
        rend = GetComponent<SpriteRenderer>();  //이게 필요한가??????????????????????????
    }*/
    private void Update()
    {
        //hpbar.gameObject.transform.localPosition = gameObject.transform.position;
       
        if (hp <=0)
        {
            Time.timeScale = 0;
            if (Manager.manager.life_cnt == 1)
            {
                Manager.manager.respawn_Page.gameObject.SetActive(true);
            }
            else
                Manager.manager.Dis_Ad_Respawn_Page();
        }
        float x = joy_Stick.Horizontal();
        float y = joy_Stick.Vertical();

        if( x != 0 || y !=0)
        {
            transform.position += new Vector3(x, y, 0) * speed * Time.deltaTime;
        }

        shadowPartner1.transform.position = Vector3.MoveTowards(shadowPartner1.transform.position,
                shadowPartner1_Loca.transform.position, Time.deltaTime * shadowPartner_speed);
        shadowPartner2.transform.position = Vector3.MoveTowards(shadowPartner2.transform.position,
            shadowPartner2_Loca.transform.position, Time.deltaTime * shadowPartner_speed);


        Vector3 flip = transform.localScale;
        /*if (hp == hp_max)
        {
            hpbar.gameObject.SetActive(false);
        }
        else
        {
            hpbar.gameObject.SetActive(true);
            // 오브젝트에 따른 HP Bar 위치 이동
            //hpbar.gameObject.transform.localPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position + new Vector3(0, 0.8f, 0));
            //hpbar.gameObject.transform.localPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 45f);
            hpbar.gameObject.transform.localScale = flip;
        }*/


        if (Data.Instance.gameData.voltTackle_lv>0)
        {
            //볼트태클
            if (volttackle_Tmp_CT > 0)
                volttackle_Tmp_CT -= Time.deltaTime;
            else
            {
                volttackle.gameObject.SetActive(true);
                volttackle_Tmp_CT = volttackle_CT;
            }
        }

        if (hp == hp_max)
            hpbar.gameObject.SetActive(false);
        else
            hpbar.gameObject.SetActive(true);


        hpbar_Fill.transform.localScale = new Vector3(0.145f * (hp / hp_max), hpbar_Fill.transform.localScale.y);

        //HP();
        //StopAllCoroutines();//HPCoroutine() 돌리려면 이거 해야된데 
        //StartCoroutine(HPCoroutine()); //망할 왜안됨?
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Mob1" || collision.tag == "Bat_Body" || collision.tag == "GateKeeper" || collision.tag == "Bat_Boss" || collision.tag == "Golem" || collision.tag == "Golem_Boss" || collision.tag == "Redspit_Boss")
        {
            objectManager.is_atk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Mob1" || collision.tag == "Bat_Body" || collision.tag == "GateKeeper" || collision.tag == "Bat_Boss" || collision.tag == "Golem" || collision.tag == "Golem_Boss" || collision.tag == "Redspit_Boss")
        {
            objectManager.is_atk = false;
        }
    }
    /*private void HP()
    {
       hpbar.value = (float)hp / (float)hp_max;
    }*/

    /*IEnumerator HPCoroutine()  //몇초동안 공격 안받으면 다시 끄는 코루틴인데 왜안댐?;;;;
    {
        yield return new WaitForSeconds(3f);
        hpbar.gameObject.SetActive(false);
    }*/
}
