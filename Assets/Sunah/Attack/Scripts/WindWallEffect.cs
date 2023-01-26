using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindWallEffect : MonoBehaviour
{

    public float x;
    public float y;

    private void OnEnable()
    {
        x = 1f;
        y = 1f;
        gameObject.transform.localScale = new Vector3(x, y);
        StartCoroutine(Up());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Up()
    {
        for(int i=0; i<100; i++)
        {
            x += 0.05f;
            y += 0.05f;
            gameObject.transform.localScale = new Vector3(x, y);
            yield return new WaitForSeconds(0.01f); //특정시간 뒤에 함수 호출

        }
        yield return new WaitForSeconds(1f); //delay 주기 히히
        gameObject.SetActive(false);

    }
    
}
