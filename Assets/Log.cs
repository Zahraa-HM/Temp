using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    // De
    public int jumpForce = 1;

    public GameObject obj;
    public Rigidbody2D rb;


    void Start() // = Main
    {
        rb = obj.GetComponent<Rigidbody2D>();
    }
    void Update() // = Main every frame (maybe 100/s)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0.1f, 200f * JumpForce(jumpForce)));
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

    int JumpForce(int jumpForce)
    {
        jumpForce += 1;
        return jumpForce;
    }

}