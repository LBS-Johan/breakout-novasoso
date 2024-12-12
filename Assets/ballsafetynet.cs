using UnityEngine;
using UnityEngine.SceneManagement;

public class ballsafetynet : MonoBehaviour
{
    public int health;
    public AudioClip breaksound; // Assign the audio clip in the inspector
    private AudioSource audioSource;
    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = breaksound;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        loselife();
    }
    //personal methods
    private void loselife()
    {
        health -= 1;
        audioSource.Play();
        if (health <= 0)
        {
            dead = true;
            Invoke("sceneloader", 5f);
        }
        transform.position = new Vector2(0, 0);
    }
    private void sceneloader()
    {
        SceneManager.LoadScene("menu");
    }
}
