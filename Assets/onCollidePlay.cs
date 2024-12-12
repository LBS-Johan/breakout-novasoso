using UnityEngine;

public class onCollidePlay : MonoBehaviour
{
    public AudioClip collisionSound; // Assign the audio clip in the inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = collisionSound;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            audioSource.Play();
    }
}
