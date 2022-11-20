using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameControllerScript gameControllerScript;
    public AudioSource collectBoxAudio;
    public AudioSource gameOverAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectables"))
        {
            collectBoxAudio.Play();
            Destroy(other.gameObject);
            score.AddScore(1);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            gameOverAudio.Play();
            playerScript.enabled = false;
            gameControllerScript.ShowGameOverPanal(true);
        }
    }
}
