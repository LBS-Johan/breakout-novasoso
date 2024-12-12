using UnityEngine;

public class paddle : MonoBehaviour
{
    Rigidbody2D rb;
    float moveInput;
    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        keybinds();
    }
    private void FixedUpdate()
    {
        movement();
    }
    void movement()
    {
        moveInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveInput * moveSpeed, 0f);
        rb.velocity = new Vector2(movement.x, rb.velocity.y);
    }
    void keybinds()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
