using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is applied to the enemy UFOs. Destroys them when they are hit by the laser bolt.
public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager;
    public int scoreToGive = 1;
    public ParticleSystem explosionParticle; // In the Unity inspector this makes a box to put the Explosion PreFab in.

    private AudioSource audioSourceExplosion;
    public AudioClip explosionClip;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Referencing scoreManger script?
        audioSourceExplosion = GameObject.Find("AudioSource-Explosion").GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LaserBolt"))
        {
            Destroy(gameObject); // Destroys the UFO.
            Destroy(other.gameObject); // Destroys the laser bolt.
            scoreManager.IncreaseScore(scoreToGive); //Increase score.
            Explosion();
            audioSourceExplosion.PlayOneShot(explosionClip, 1.0F);
        }
        // If UFO collides with anything besides laser (only other thing is the collectable), then UFO is destroyed.
        Explosion();
        Destroy(gameObject);
    }
    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }
}
