using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is applied to the enemy UFOs. Destroys them when they are hit by the laser bolt.
public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager;
    public int scoreToGive = 1;
    //public ParticleSystem explosionParticle;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Referencing scoreManger script?
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LaserBolt"))
        {
            Destroy(gameObject); // Destroys the UFO.
            Destroy(other.gameObject); // Destroys the laser bolt.
        }
        //Explosion();
        scoreManager.IncreaseScore(scoreToGive); //Increase score.
    }
    /* VoidExplosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }
    */
}
