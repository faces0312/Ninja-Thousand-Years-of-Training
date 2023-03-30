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
    public Animator animator_walk; // �ȱ�

    public float speed;

    public ShadowPartner shadowPartner1;
    public ShadowPartner shadowPartner2;
    public GameObject shadowPartner1_Loca;
    public GameObject shadowPartner2_Loca;
    private float shadowPartner_speed = 2.8f;

    //��Ʈ ��Ŭ
    //public Animator animator_voltTackle; // �ȱ�
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
        rend = GetComponent<SpriteRenderer>();  //�̰� �ʿ��Ѱ�??????????????????????????
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
            // ������Ʈ�� ���� HP Bar ��ġ �̵�
            //hpbar.gameObject.transform.localPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position + new Vector3(0, 0.8f, 0));
            //hpbar.gameObject.transform.localPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 45f);
            hpbar.gameObject.transform.localScale = flip;
        }*/


        if (Data.Instance.gameData.voltTackle_lv>0)
        {
            //��Ʈ��Ŭ
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
        //StopAllCoroutines();//HPCoroutine() �������� �̰� �ؾߵȵ� 
        //StartCoroutine(HPCoroutine()); //���� �־ȵ�?
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

    /*IEnumerator HPCoroutine()  //���ʵ��� ���� �ȹ����� �ٽ� ���� �ڷ�ƾ�ε� �־ȴ�?;;;;
    {
        yield return new WaitForSeconds(3f);
        hpbar.gameObject.SetActive(false);
    }*/
}
