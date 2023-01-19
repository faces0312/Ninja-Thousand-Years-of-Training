using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class JoyStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform move_background;
    [SerializeField] private RectTransform move;
    private float radius;

    //캐릭터 이동
    public Player player;
    //public bool is_move = false;

    public Vector2 movePositon;


    void Start()
    {
        radius = move_background.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position += (Vector3)movePositon;

        if (move.anchoredPosition.x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -0.7f;
            scale.y *= 0.7f;
            player.transform.localScale = scale;
        }
        else if (move.anchoredPosition.x > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= 0.7f;
            scale.y *= 0.7f;
            player.transform.localScale = scale;
        }

        /*if(Input.GetMouseButtonDown(0))
        {
            Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, -Camera.main.transform.position.z));

            gameObject.transform.localPosition = point;

            Debug.Log(point.ToString());
        }*/
    }




    public void OnDrag(PointerEventData eventData)
    {
        Vector2 value = eventData.position - (Vector2)move_background.position;

        value = Vector2.ClampMagnitude(value, radius);
        move.localPosition = value;
        value = value.normalized;
        float distance = Vector2.Distance(move_background.position, move.position) / radius;
        movePositon = new Vector3(value.x * player.speed * Time.deltaTime * distance, value.y * player.speed * Time.deltaTime * distance, 0f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        player.animator_walk.SetBool("Is_Walk", true);
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        player.animator_walk.SetBool("Is_Walk", false);
        move.localPosition = Vector3.zero;
        movePositon = Vector3.zero;
    }
}