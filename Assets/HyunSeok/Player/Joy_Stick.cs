using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Joy_Stick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Player player;
    public ShadowPartner shadowPartner1;
    public ShadowPartner shadowPartner2;
    private Image imageBackGround;
    private Image imageController;



    private Vector2 touchPosition;
    void Awake()
    {
        imageBackGround = GetComponent<Image>();
        imageController = transform.GetChild(0).GetComponent<Image>();
    }

    void FixedUpdate()
    {
        if (touchPosition.x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -0.7f;
            scale.y *= 0.7f;
            player.transform.localScale = scale;
            shadowPartner1.transform.localScale = scale;
            shadowPartner2.transform.localScale = scale;

            Vector3 scale_hp = transform.localScale;
            scale_hp.x *= -1f;
            scale_hp.y *= 1f;
            player.hpbar.transform.localScale = scale_hp;
        }
        else if (touchPosition.x > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= 0.7f;
            scale.y *= 0.7f;
            player.transform.localScale = scale;
            shadowPartner1.transform.localScale = scale;
            shadowPartner2.transform.localScale = scale;

            Vector3 scale_hp = transform.localScale;
            scale_hp.x *= 1f;
            scale_hp.y *= 1f;
            player.hpbar.transform.localScale = scale_hp;
        }
    }


    public void OnDrag(PointerEventData eventData)
    {
        touchPosition = Vector2.zero;

        player.animator_walk.SetBool("Is_Walk", true);
        if(shadowPartner1.gameObject.activeSelf == true)
            shadowPartner1.animator_walk.SetBool("Is_Walk", true);
        if (shadowPartner2.gameObject.activeSelf == true)
            shadowPartner2.animator_walk.SetBool("Is_Walk", true);

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(imageBackGround.rectTransform, eventData.position, eventData.pressEventCamera, out touchPosition))
        {
            touchPosition.x = (touchPosition.x / imageBackGround.rectTransform.sizeDelta.x);
            touchPosition.y = (touchPosition.y / imageBackGround.rectTransform.sizeDelta.y);

            touchPosition = new Vector2(touchPosition.x * 2 - 1, touchPosition.y * 2 - 1);

            touchPosition = (touchPosition.magnitude > 1) ? touchPosition.normalized : touchPosition;

            imageController.rectTransform.anchoredPosition = new Vector2(touchPosition.x * imageBackGround.rectTransform.sizeDelta.x / 2,
                touchPosition.y * imageBackGround.rectTransform.sizeDelta.y / 2);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        player.animator_walk.SetBool("Is_Walk", true);
        if (shadowPartner1.gameObject.activeSelf == true)
            shadowPartner1.animator_walk.SetBool("Is_Walk", true);
        if (shadowPartner2.gameObject.activeSelf == true)
            shadowPartner2.animator_walk.SetBool("Is_Walk", true);
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        player.animator_walk.SetBool("Is_Walk", false);
        if(shadowPartner1.gameObject.activeSelf == true)
            shadowPartner1.animator_walk.SetBool("Is_Walk", false);
        if (shadowPartner2.gameObject.activeSelf == true)
            shadowPartner2.animator_walk.SetBool("Is_Walk", false);
        imageController.rectTransform.anchoredPosition = Vector2.zero;
        touchPosition = Vector2.zero;
    }

    public float Horizontal()
    {
        return touchPosition.x;
    }

    public float Vertical()
    {
        return touchPosition.y;
    }
}
