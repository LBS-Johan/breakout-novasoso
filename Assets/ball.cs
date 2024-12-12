using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    score score;
    public int rotationSpeed;
    public float slowAllowness;
    private bool slowYBallDetected;
    private bool slowXBallDetected;
    // Start is called before the first frame update
    void Start()
    {
        //defining stuff ig
        score = GameObject.Find("Score").GetComponent<score>(); 
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(2, 2);
        slowXBallDetected = false;
        slowYBallDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        setConstantSpeed();  //sets constant speed every frame;
        slowDetect(rb.velocity);  //checks if ball speed is within the disallowed range
    }
    private void FixedUpdate()
    {
        Rotate(rotationSpeed);  //spins ball
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        destroyBlock(collision);  //destroy block if its destroyable
        if (slowYBallDetected == true)
        {
            Invoke("slowYBallCorrection", 0.5f);
        }
        else if (slowXBallDetected == true)
        {
            Invoke("slowXBallCorrection", 0.5f);
        }  //corrects slow ball movement through a random bounce IF slowX/YBallDetected == true
    }
    //personal methods
    void setConstantSpeed()
    {
        rb.velocity = rb.velocity.normalized * 7;
    }
    void Rotate(int speed)
    {

        transform.Rotate(new Vector3(0, 0, speed));
    }
    void destroyBlock(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("destroyme"))
        {
            Destroy(collision.gameObject);
            score.points += 100;
        }
    }
    void slowDetect(Vector2 velocity)
    {
        if (velocity.x <= slowAllowness && velocity.x >= -slowAllowness)
        {
            if(slowXBallDetected == false)
            {
                print($"{rb.velocity.x} is the balls x speed, it is lower than {slowAllowness} and higher than {-slowAllowness}");
                slowXBallDetected = true;
            }
        }
        else if (velocity.y <= slowAllowness && velocity.y >= -slowAllowness)
        {
            if (slowYBallDetected == false)
            {
                print($"{rb.velocity.y} is the balls y speed, it is lower than {slowAllowness} and higher than {-slowAllowness}");
                slowYBallDetected = true;
            }
        }
        else
        {
            slowXBallDetected = false;
            slowYBallDetected = false;
        }
    }
    void slowXBallCorrection()
    {
        slowDetect(rb.velocity);
        if (slowXBallDetected == true)
        {
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector2(2f, -rb.velocity.y);
                slowXBallDetected = false;
            }
            else if (rb.velocity.x > 0)
            {
                rb.velocity = new Vector2(-2f, rb.velocity.y);
                slowXBallDetected = false;
            }
        }
    }
    void slowYBallCorrection()
    {
        slowDetect(rb.velocity);
        if (slowYBallDetected == true)
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity = new Vector2(-rb.velocity.x, 2f);
                print($"corrected y speed is now 2 = {rb.velocity.y}");
            }
            else if (rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, -2f);
                print($"corrected y speed is now 2 = {rb.velocity.y}");
            }
            slowYBallDetected = false;
        }
    }
}
