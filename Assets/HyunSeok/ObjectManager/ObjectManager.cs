using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public ObjectPool objectPool;
    public Player player;
    public ShadowPartner shadowPartner1;
    public ShadowPartner shadowPartner2;

    private string[] atk_str;
    private string[] mob_str;
    private string[] letter_str;

    public GameObject[] mob_Location;
    private float mob_CT;//¸÷ ÄðÅ¸ÀÓ
    private float mob_Tmp_CT;

    Mob closetEnemy;
    GameObject atk_normal;
    GameObject atk_shadow;
    GameObject frieColumn;

    public bool is_atk;//(¸Ê¾È¿¡ ¸÷ÀÌ ÀÖ´Â »óÅÂÀÎÁö)

    //----------------ÀüÃ¼ ÄðÅ¸ÀÓ
    public float atk_normal_CT;//Ç¥Ã¢ ÄðÅ¸ÀÓ
    public float shadow_partner_CT;//½¦µµ¿ì ÆÄÆ®³Ê ÄðÅ¸ÀÓ
    public float fire_CT;
    public float lighting_CT;
    public float talisman_CT;
    public float firecolumn_CT;
    public float woodTrap_CT;
    public float tornado_CT;
    public float tree_CT;
    

    //-------------ÇöÀç ½Ã°£ ÄðÅ¸ÀÓ
    private float atk_normal_Tmp_CT;
    private float shadow_partner_Tmp_CT;
    private float fire_Tmp_CT;
    private float lighting_Tmp_CT;
    private float talisman_Tmp_CT;
    private float firecolumn_Tmp_CT;
    public float woodTrap_Tmp_CT;
    public float tornado_Tmp_CT;
    private float tree_Tmp_CT;



    void Awake()
    {
        atk_str = new string[] { "Normal_Atk" , "Shadow_Atk" ,"Fire", "Lighting", "Talisman", "FireColumn", "WoodTrap", "Tornado", "Tree"};
        mob_str = new string[] { "Mob1" };
        letter_str = new string[] { "Normal_Atk_Letter" };
    }

    private void Start()
    {
        mob_CT = 5f;
        mob_Tmp_CT = mob_CT;

        atk_normal_CT = 0.5f;
        atk_normal_Tmp_CT = atk_normal_CT;

        shadow_partner_CT = 1f;
        shadow_partner_Tmp_CT = shadow_partner_CT;

        fire_CT = 7f;
        fire_Tmp_CT = fire_CT;

        lighting_CT = 3f;
        lighting_Tmp_CT = lighting_CT;

        talisman_CT = 3.7f;
        talisman_Tmp_CT = talisman_CT;

        firecolumn_CT = 3f;
        firecolumn_Tmp_CT = firecolumn_CT;

        woodTrap_CT = 5f;
        woodTrap_Tmp_CT = woodTrap_CT;

        tornado_CT = 5f;
        tornado_Tmp_CT = tornado_CT;

        tree_CT = 3f;
        tree_Tmp_CT = tree_CT;
    }

    private void Update()
    {
        //¸÷ »ý¼º Äð
        if (mob_Tmp_CT > 0)
            mob_Tmp_CT -= Time.deltaTime;
        else
        {
            Mob_General();
            mob_Tmp_CT = mob_CT;
        }

        
        /*if (is_atk == true)
        {
            if (atk_normal_Tmp_CT > 0)
                atk_normal_Tmp_CT -= Time.deltaTime;
            else
            {
                Normal_Atk_General();
                atk_normal_Tmp_CT = atk_normal_CT;
            }

            if (Data.Instance.gameData.shadow_partner_lv > 0)
            {
                if (shadow_partner_Tmp_CT > 0)
                    shadow_partner_Tmp_CT -= Time.deltaTime;
                else
                {
                    if (Data.Instance.gameData.shadow_partner_lv == 6)
                    {
                        ShadowPartner1_Atk_General();
                        ShadowPartner2_Atk_General();
                    }
                    else
                        ShadowPartner1_Atk_General();
                    shadow_partner_Tmp_CT = shadow_partner_CT;
                }
            }
        }*/
        

        if (Data.Instance.gameData.fire_lv > 0)
        {
            if (fire_Tmp_CT > 0)
                fire_Tmp_CT -= Time.deltaTime;
            else
            {
                if(Data.Instance.gameData.fire_lv == 1)
                {
                    Fire1_General();
                }
                else if (Data.Instance.gameData.fire_lv == 2)
                {
                    Fire1_General();
                }
                else if (Data.Instance.gameData.fire_lv == 3)
                {
                    Fire2_General();
                }
                else if (Data.Instance.gameData.fire_lv == 4)
                {
                    Fire4_General();
                }
                else if (Data.Instance.gameData.fire_lv == 5)
                {
                    Fire4_General();
                }
                else if (Data.Instance.gameData.fire_lv == 6)
                {
                    Fire12_General();
                }
                fire_Tmp_CT = fire_CT;
            }
        }

        if(Data.Instance.gameData.lightning_lv > 0)
        {
            if (lighting_Tmp_CT > 0)
                lighting_Tmp_CT -= Time.deltaTime;
            else
            {
                if (Data.Instance.gameData.lightning_lv == 6)
                    Lighting_General();

                lighting_Tmp_CT = lighting_CT;
            }
        }

        if (Data.Instance.gameData.talisman_lv > 0)
        {
            if (talisman_Tmp_CT > 0)
                talisman_Tmp_CT -= Time.deltaTime;
            else
            {
                StartCoroutine("Talisman_General");
                talisman_Tmp_CT = talisman_CT;
            }
        }

        if(Data.Instance.gameData.fire_column_lv > 0)
        {
            if (firecolumn_Tmp_CT > 0)
                firecolumn_Tmp_CT -= Time.deltaTime;
            else
            {
                FireColumn_General();
                firecolumn_Tmp_CT = firecolumn_CT;
            }
        }

        if (Data.Instance.gameData.woodTrap_lv > 0)
        {
            if (woodTrap_Tmp_CT > 0)
                woodTrap_Tmp_CT -= Time.deltaTime;
            else
            {
                WoodTrap_General();
                woodTrap_Tmp_CT = woodTrap_CT;
            }
        }

        if (Data.Instance.gameData.tornado_lv > 0)
        {
            if (tornado_Tmp_CT > 0)
                tornado_Tmp_CT -= Time.deltaTime;
            else
            {
                Tornado_General();
                tornado_Tmp_CT = tornado_CT;
            }
        }
        if (Data.Instance.gameData.tree_lv > 0)
        {
            if (tree_Tmp_CT > 0)
                tree_Tmp_CT -= Time.deltaTime;
            else
            { //
                Tree_General(); 
                tree_Tmp_CT = tree_CT;
            }
        }
    }

    public void Normal_Atk_Letter_General(Vector3 vector3)
    {
        GameObject letter;
        letter = objectPool.MakeObj(letter_str[0]);

        letter.transform.position = vector3;
    }

    public void Mob_General()
    {
        GameObject mob1;
        mob1 = objectPool.MakeObj(mob_str[0]);

        int ran_location;

        ran_location = Random.Range(0, 29);
        mob1.transform.position = mob_Location[ran_location].transform.position;
    }

    public void Normal_Atk_General()
    {
        float distanceClosetEnemy = Mathf.Infinity;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
            }
        }

        atk_normal = objectPool.MakeObj(atk_str[0]);
        atk_normal.transform.position = player.transform.position;
        Vector3 start = atk_normal.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_normal.transform.rotation = Quaternion.Euler(atk_normal.transform.rotation.x, atk_normal.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
    }
    public void ShadowPartner1_Atk_General()
    {
        float distanceClosetEnemy = Mathf.Infinity;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - shadowPartner1.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
            }
        }

        atk_shadow = objectPool.MakeObj(atk_str[1]);
        atk_shadow.transform.position = shadowPartner1.transform.position;
        Vector3 start = atk_shadow.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_shadow.transform.rotation = Quaternion.Euler(atk_shadow.transform.rotation.x, atk_shadow.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
    }
    public void ShadowPartner2_Atk_General()
    {
        float distanceClosetEnemy = Mathf.Infinity;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - shadowPartner2.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
            }
        }

        atk_shadow = objectPool.MakeObj(atk_str[1]);
        atk_shadow.transform.position = shadowPartner2.transform.position;
        Vector3 start = atk_shadow.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_shadow.transform.rotation = Quaternion.Euler(atk_shadow.transform.rotation.x, atk_shadow.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);
    }
    public void Fire1_General()
    {
        GameObject fire1;
        fire1 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;

        if(player.gameObject.transform.localScale.x < 0)
            fire1.transform.localEulerAngles = new Vector3(0, 0, 180);
        else
            fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
    }
    public void Fire2_General()
    {
        GameObject fire1;
        GameObject fire2;
        fire1 = objectPool.MakeObj(atk_str[2]);
        fire2 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;
        fire2.transform.position = player.transform.position;

        fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
        fire2.transform.localEulerAngles = new Vector3(0, 0, 180);
    }
    public void Fire4_General()
    {
        GameObject fire1;
        GameObject fire2;
        GameObject fire3;
        GameObject fire4;
        fire1 = objectPool.MakeObj(atk_str[2]);
        fire2 = objectPool.MakeObj(atk_str[2]);
        fire3 = objectPool.MakeObj(atk_str[2]);
        fire4 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;
        fire2.transform.position = player.transform.position;
        fire3.transform.position = player.transform.position;
        fire4.transform.position = player.transform.position;

        fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
        fire2.transform.localEulerAngles = new Vector3(0, 0, 90);
        fire3.transform.localEulerAngles = new Vector3(0, 0, 180);
        fire4.transform.localEulerAngles = new Vector3(0, 0, 270);
    }
    public void Fire12_General()
    {
        GameObject fire1;
        GameObject fire2;
        GameObject fire3;
        GameObject fire4;
        GameObject fire5;
        GameObject fire6;
        GameObject fire7;
        GameObject fire8;
        GameObject fire9;
        GameObject fire10;
        GameObject fire11;
        GameObject fire12;
        fire1 = objectPool.MakeObj(atk_str[2]);
        fire2 = objectPool.MakeObj(atk_str[2]);
        fire3 = objectPool.MakeObj(atk_str[2]);
        fire4 = objectPool.MakeObj(atk_str[2]);
        fire5 = objectPool.MakeObj(atk_str[2]);
        fire6 = objectPool.MakeObj(atk_str[2]);
        fire7 = objectPool.MakeObj(atk_str[2]);
        fire8 = objectPool.MakeObj(atk_str[2]);
        fire9 = objectPool.MakeObj(atk_str[2]);
        fire10 = objectPool.MakeObj(atk_str[2]);
        fire11 = objectPool.MakeObj(atk_str[2]);
        fire12 = objectPool.MakeObj(atk_str[2]);

        fire1.transform.position = player.transform.position;
        fire2.transform.position = player.transform.position;
        fire3.transform.position = player.transform.position;
        fire4.transform.position = player.transform.position;
        fire5.transform.position = player.transform.position;
        fire6.transform.position = player.transform.position;
        fire7.transform.position = player.transform.position;
        fire8.transform.position = player.transform.position;
        fire9.transform.position = player.transform.position;
        fire10.transform.position = player.transform.position;
        fire11.transform.position = player.transform.position;
        fire12.transform.position = player.transform.position;

        fire1.transform.localEulerAngles = new Vector3(0, 0, 0);
        fire2.transform.localEulerAngles = new Vector3(0, 0, 30);
        fire3.transform.localEulerAngles = new Vector3(0, 0, 60);
        fire4.transform.localEulerAngles = new Vector3(0, 0, 90);
        fire5.transform.localEulerAngles = new Vector3(0, 0, 120);
        fire6.transform.localEulerAngles = new Vector3(0, 0, 150);
        fire7.transform.localEulerAngles = new Vector3(0, 0, 180);
        fire8.transform.localEulerAngles = new Vector3(0, 0, 210);
        fire9.transform.localEulerAngles = new Vector3(0, 0, 240);
        fire10.transform.localEulerAngles = new Vector3(0, 0, 270);
        fire11.transform.localEulerAngles = new Vector3(0, 0, 300);
        fire12.transform.localEulerAngles = new Vector3(0, 0, 330);
    }

    public void Lighting_General()
    {
        GameObject lighting1;
        GameObject lighting2;
        GameObject lighting3;
        GameObject lighting4;
        GameObject lighting5;
        GameObject lighting6;
        GameObject lighting7;
        GameObject lighting8;
        GameObject lighting9;
        GameObject lighting10;
        GameObject lighting11;
        GameObject lighting12;

        lighting1 = objectPool.MakeObj(atk_str[3]);
        lighting2 = objectPool.MakeObj(atk_str[3]);
        lighting3 = objectPool.MakeObj(atk_str[3]);
        lighting4 = objectPool.MakeObj(atk_str[3]);
        lighting5 = objectPool.MakeObj(atk_str[3]);
        lighting6 = objectPool.MakeObj(atk_str[3]);
        lighting7 = objectPool.MakeObj(atk_str[3]);
        lighting8 = objectPool.MakeObj(atk_str[3]);
        lighting9 = objectPool.MakeObj(atk_str[3]);
        lighting10 = objectPool.MakeObj(atk_str[3]);
        lighting11 = objectPool.MakeObj(atk_str[3]);
        lighting12 = objectPool.MakeObj(atk_str[3]);

        lighting1.transform.position = player.transform.position + new Vector3(1.75f, 0.7f);
        lighting2.transform.position = player.transform.position + new Vector3(0, 1.8f);
        lighting3.transform.position = player.transform.position + new Vector3(-1.8f, 0.7f);
        lighting4.transform.position = player.transform.position + new Vector3(0, -0.4f);
        lighting5.transform.position = player.transform.position + new Vector3(1.3f, 1.3f);
        lighting6.transform.position = player.transform.position + new Vector3(0.7f, 1.75f);
        lighting7.transform.position = player.transform.position + new Vector3(-1.3f, 1.3f);
        lighting8.transform.position = player.transform.position + new Vector3(-0.7f, 1.75f);
        lighting9.transform.position = player.transform.position + new Vector3(-1.3f, 0.2f);
        lighting10.transform.position = player.transform.position + new Vector3(-0.7f, -0.25f);
        lighting11.transform.position = player.transform.position + new Vector3(1.3f, 0.2f);
        lighting12.transform.position = player.transform.position + new Vector3(0.7f, -0.25f);
    }

    IEnumerator Talisman_General()
    {
        GameObject talisman1;
        talisman1 = objectPool.MakeObj(atk_str[4]);
        talisman1.transform.position = player.transform.position;
        talisman1.transform.localEulerAngles = new Vector3(0, 0, -90);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman2;
        talisman2 = objectPool.MakeObj(atk_str[4]);
        talisman2.transform.position = player.transform.position;
        talisman2.transform.localEulerAngles = new Vector3(0, 0, -80);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman3;
        talisman3 = objectPool.MakeObj(atk_str[4]);
        talisman3.transform.position = player.transform.position;
        talisman3.transform.localEulerAngles = new Vector3(0, 0, -70);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman4;
        talisman4 = objectPool.MakeObj(atk_str[4]);
        talisman4.transform.position = player.transform.position;
        talisman4.transform.localEulerAngles = new Vector3(0, 0, -60);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman5;
        talisman5 = objectPool.MakeObj(atk_str[4]);
        talisman5.transform.position = player.transform.position;
        talisman5.transform.localEulerAngles = new Vector3(0, 0, -50);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman6;
        talisman6 = objectPool.MakeObj(atk_str[4]);
        talisman6.transform.position = player.transform.position;
        talisman6.transform.localEulerAngles = new Vector3(0, 0, -40);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman7;
        talisman7 = objectPool.MakeObj(atk_str[4]);
        talisman7.transform.position = player.transform.position;
        talisman7.transform.localEulerAngles = new Vector3(0, 0, -30);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman8;
        talisman8 = objectPool.MakeObj(atk_str[4]);
        talisman8.transform.position = player.transform.position;
        talisman8.transform.localEulerAngles = new Vector3(0, 0, -20);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman9;
        talisman9 = objectPool.MakeObj(atk_str[4]);
        talisman9.transform.position = player.transform.position;
        talisman9.transform.localEulerAngles = new Vector3(0, 0, -10);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman10;
        talisman10 = objectPool.MakeObj(atk_str[4]);
        talisman10.transform.position = player.transform.position;
        talisman10.transform.localEulerAngles = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman11;
        talisman11 = objectPool.MakeObj(atk_str[4]);
        talisman11.transform.position = player.transform.position;
        talisman11.transform.localEulerAngles = new Vector3(0, 0, 10);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman12;
        talisman12 = objectPool.MakeObj(atk_str[4]);
        talisman12.transform.position = player.transform.position;
        talisman12.transform.localEulerAngles = new Vector3(0, 0, 20);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman13;
        talisman13 = objectPool.MakeObj(atk_str[4]);
        talisman13.transform.position = player.transform.position;
        talisman13.transform.localEulerAngles = new Vector3(0, 0, 30);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman14;
        talisman14 = objectPool.MakeObj(atk_str[4]);
        talisman14.transform.position = player.transform.position;
        talisman14.transform.localEulerAngles = new Vector3(0, 0, 40);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman15;
        talisman15 = objectPool.MakeObj(atk_str[4]);
        talisman15.transform.position = player.transform.position;
        talisman15.transform.localEulerAngles = new Vector3(0, 0, 50);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman16;
        talisman16 = objectPool.MakeObj(atk_str[4]);
        talisman16.transform.position = player.transform.position;
        talisman16.transform.localEulerAngles = new Vector3(0, 0, 60);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman17;
        talisman17 = objectPool.MakeObj(atk_str[4]);
        talisman17.transform.position = player.transform.position;
        talisman17.transform.localEulerAngles = new Vector3(0, 0, 70);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman18;
        talisman18 = objectPool.MakeObj(atk_str[4]);
        talisman18.transform.position = player.transform.position;
        talisman18.transform.localEulerAngles = new Vector3(0, 0, 80);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman19;
        talisman19 = objectPool.MakeObj(atk_str[4]);
        talisman19.transform.position = player.transform.position;
        talisman19.transform.localEulerAngles = new Vector3(0, 0, 90);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman20;
        talisman20 = objectPool.MakeObj(atk_str[4]);
        talisman20.transform.position = player.transform.position;
        talisman20.transform.localEulerAngles = new Vector3(0, 0, 100);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman21;
        talisman21 = objectPool.MakeObj(atk_str[4]);
        talisman21.transform.position = player.transform.position;
        talisman21.transform.localEulerAngles = new Vector3(0, 0, 110);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman22;
        talisman22 = objectPool.MakeObj(atk_str[4]);
        talisman22.transform.position = player.transform.position;
        talisman22.transform.localEulerAngles = new Vector3(0, 0, 120);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman23;
        talisman23 = objectPool.MakeObj(atk_str[4]);
        talisman23.transform.position = player.transform.position;
        talisman23.transform.localEulerAngles = new Vector3(0, 0, 130);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman24;
        talisman24 = objectPool.MakeObj(atk_str[4]);
        talisman24.transform.position = player.transform.position;
        talisman24.transform.localEulerAngles = new Vector3(0, 0, 140);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman25;
        talisman25 = objectPool.MakeObj(atk_str[4]);
        talisman25.transform.position = player.transform.position;
        talisman25.transform.localEulerAngles = new Vector3(0, 0, 150);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman26;
        talisman26 = objectPool.MakeObj(atk_str[4]);
        talisman26.transform.position = player.transform.position;
        talisman26.transform.localEulerAngles = new Vector3(0, 0, 160);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman27;
        talisman27 = objectPool.MakeObj(atk_str[4]);
        talisman27.transform.position = player.transform.position;
        talisman27.transform.localEulerAngles = new Vector3(0, 0, 170);
        yield return new WaitForSeconds(0.1f);


        GameObject talisman28;
        talisman28 = objectPool.MakeObj(atk_str[4]);
        talisman28.transform.position = player.transform.position;
        talisman28.transform.localEulerAngles = new Vector3(0, 0, 180);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman29;
        talisman29 = objectPool.MakeObj(atk_str[4]);
        talisman29.transform.position = player.transform.position;
        talisman29.transform.localEulerAngles = new Vector3(0, 0, 190);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman30;
        talisman30 = objectPool.MakeObj(atk_str[4]);
        talisman30.transform.position = player.transform.position;
        talisman30.transform.localEulerAngles = new Vector3(0, 0, 200);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman31;
        talisman31 = objectPool.MakeObj(atk_str[4]);
        talisman31.transform.position = player.transform.position;
        talisman31.transform.localEulerAngles = new Vector3(0, 0, 210);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman32;
        talisman32 = objectPool.MakeObj(atk_str[4]);
        talisman32.transform.position = player.transform.position;
        talisman32.transform.localEulerAngles = new Vector3(0, 0, 220);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman33;
        talisman33 = objectPool.MakeObj(atk_str[4]);
        talisman33.transform.position = player.transform.position;
        talisman33.transform.localEulerAngles = new Vector3(0, 0, 230);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman34;
        talisman34 = objectPool.MakeObj(atk_str[4]);
        talisman34.transform.position = player.transform.position;
        talisman34.transform.localEulerAngles = new Vector3(0, 0, 240);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman35;
        talisman35 = objectPool.MakeObj(atk_str[4]);
        talisman35.transform.position = player.transform.position;
        talisman35.transform.localEulerAngles = new Vector3(0, 0, 250);
        yield return new WaitForSeconds(0.1f);

        GameObject talisman36;
        talisman36 = objectPool.MakeObj(atk_str[4]);
        talisman36.transform.position = player.transform.position;
        talisman36.transform.localEulerAngles = new Vector3(0, 0, 260);
        yield return new WaitForSeconds(0.1f);

    }

    public void FireColumn_General()
    {
        
        float distanceClosetEnemy = 13f;
        closetEnemy = null;
        Mob[] allenemys = GameObject.FindObjectsOfType<Mob>();

        if (allenemys.Length == 0)
            return;

        foreach (Mob currentEnemy in allenemys)
        {
            float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceClosetEnemy)
            {
                distanceClosetEnemy = distanceToEnemy;
                closetEnemy = currentEnemy;
                frieColumn = objectPool.MakeObj(atk_str[5]);
                frieColumn.transform.position = closetEnemy.transform.position;
                break;
            }
        }

        /*Vector3 start = atk_normal.transform.position;
        Vector3 end = closetEnemy.transform.position;
        Vector3 fin = end - start;
        atk_normal.transform.rotation = Quaternion.Euler(atk_normal.transform.rotation.x, atk_normal.transform.rotation.y, Quaternion.FromToRotation(Vector3.up, fin).eulerAngles.z + 90);*/
    }

    public void WoodTrap_General()
    {
        GameObject woodTrap;

        woodTrap = objectPool.MakeObj(atk_str[6]);
        woodTrap.gameObject.transform.position = player.transform.position;
    }

    public void Tornado_General()
    {
        GameObject tornado;

        tornado = objectPool.MakeObj(atk_str[7]);
        tornado.gameObject.transform.position = player.transform.position;
    }
    public void Tree_General()
    {
        GameObject tree;

        tree = objectPool.MakeObj(atk_str[8]);
        tree.gameObject.transform.position = player.transform.position;
    }
}
