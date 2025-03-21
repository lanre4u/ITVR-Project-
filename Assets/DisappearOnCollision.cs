using UnityEngine;
using UnityEngine.SceneManagement;

public class DisappearOnCollision : MonoBehaviour
{
    public AudioSource MyAudioSource;
    public AudioClip MyAudioClip;


    // This function is called when the player collides with the object
    private void OnCollisionEnter(Collision collision) //class the described collisions
    {
        // Check if the object that collided with this object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            MyAudioSource.PlayOneShot(MyAudioClip);
            gameObject.SetActive(false);
        }
    }
}
