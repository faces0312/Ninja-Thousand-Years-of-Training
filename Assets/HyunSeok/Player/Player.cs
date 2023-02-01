using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp_max;
    public float hp;

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

    // Start is called before the first frame update
    void Start()
    {
        animator_walk = GetComponent<Animator>();
        //animator_voltTackle = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();

        hp_max = 30;
        hp = hp_max;
        speed = 2;

        volttackle_CT = 23f;
        volttackle_Tmp_CT = volttackle_CT;
    }
  /*  private void OnEnable()
    {
        rend = GetComponent<SpriteRenderer>();  //�̰� �ʿ��Ѱ�??????????????????????????
    }*/
    private void Update()
    {
        if(hp <=0)
        {
            Time.timeScale = 0;
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


        if(Data.Instance.gameData.voltTackle_lv>0)
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
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Mob")
        {
            objectManager.is_atk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Mob")
        {
            objectManager.is_atk = false;
        }
    }
}
