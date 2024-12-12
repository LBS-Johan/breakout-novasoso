using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public int points;
    private ballsafetynet BallNet;
    // Start is called before the first frame update
    void Start()
    {
        BallNet = GameObject.Find("ball").GetComponent<ballsafetynet>();
        points = 0;
        scoretext = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (points >= 3000)
        {
            victory();
        }
        else if (points != 3000 && BallNet.dead == true)
        {
            dead();
        }
        else
        {
            displayScore();
        }
    }
    //personal methods
    void displayScore()
    {
        scoretext.text = "Sigma score:" + points;
    }
    void victory()
    {
        scoretext.text = "you really are sigma!! you won!!";
    }
    void dead()
    {
        scoretext.text = "noob? you lost :skull:";
    }
}
