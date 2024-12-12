using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    public static Vector3 coconutPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0,4);
            coconutPos = transform.position;
            return;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -4);
            coconutPos = transform.position;
            return;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-4, 0);
            coconutPos = transform.position;
            return;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(4, 0);
            coconutPos = transform.position;
            return;
        }
        rb.velocity = new Vector2(0, 0);
    }
}
