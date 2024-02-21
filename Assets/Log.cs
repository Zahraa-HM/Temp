using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody2D rb;


    void Start()
    {
        rb = obj.GetComponent<Rigidbody2D>();;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0.1f, 200f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(80f * Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-80f * Time.deltaTime, 0f));
        }
    }


}