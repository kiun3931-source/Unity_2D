using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OtherCircle : MonoBehaviour
{
    SpriteRenderer spr;
    //Material mat;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        //mat = mesh.material;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)  // 충돌 시작
    {
        spr.color = new Color(0, 0, 0);
    }
    /*private void OnCollisionStay2D(Collision2D collision) // 충돌 중
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision) // 충돌 끝난후
    {
        
    }*/
}
