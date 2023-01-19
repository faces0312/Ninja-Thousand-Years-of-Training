using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp;

    [SerializeField]
    private Joy_Stick joy_Stick;

    public ObjectManager objectManager;
    public Animator animator_walk; // °È±â

    public float speed = 3;

    public ShadowPartner shadowPartner1;
    public ShadowPartner shadowPartner2;
    public GameObject shadowPartner1_Loca;
    public GameObject shadowPartner2_Loca;
    private float shadowPartner_speed = 2.8f;
    public GameObject wind_Location;


    // Start is called before the first frame update
    void Start()
    {
        animator_walk = GetComponent<Animator>();
        hp = 10f;
    }

    private void Update()
    {
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

        wind_Location.transform.position = transform.position;
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
