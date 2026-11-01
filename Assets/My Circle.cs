using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyCircle : MonoBehaviour
{
    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //rigid.linearVelocity = Vector3.right;
        rigid.AddForce(Vector3.up * 5, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
