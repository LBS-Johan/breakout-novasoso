using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coconut_tp : MonoBehaviour
{
    public float xSpeed = 28;
    new Collider2D collider;
    Rigidbody2D rb;
    public LayerMask groundLayerMask;
    public UnityEngine.Transform b_portal0;
    public UnityEngine.Transform o_portal0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(xSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-xSpeed, rb.velocity.y);
        }
        else
        {
            // Stop horizontal movement when neither key is pressed
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        // Jumping
        if (Input.GetKeyDown(KeyCode.W) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, 28);
        }

        // Gravity
        if (!isGrounded())
        {
            rb.gravityScale = 2.5f;
        }
        else
        {
            rb.gravityScale = 9f;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "o_portal0")
        {
            Vector2 b_portalP = b_portal0.position;
            transform.position = b_portalP;
        }
        else if (collision.collider.name == "b_portal0")
        {
            Vector2 o_portalP = o_portal0.position;
            transform.position = o_portalP;
        }
    }

    bool isGrounded()
    {
        if (groundLayerMask == 0)
        {
            return true;
        }

        RaycastHit2D leftHit = Physics2D.Raycast(collider.bounds.min, Vector2.down, 0.3f, groundLayerMask);
        RaycastHit2D rightHit = Physics2D.Raycast(new Vector2(collider.bounds.max.x, collider.bounds.min.y), Vector2.down, 0.3f, groundLayerMask);

        return leftHit || rightHit;
    }
}

