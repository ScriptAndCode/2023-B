using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is applied to the enemy UFOs. Destroys them when they are hit by the laser bolt.
public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Referencing scoreManger script?
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LaserBolt"))
        {
            Destroy(gameObject); // Destroys this game object (one of the UFOs) when when a laser bolt hits it.
            Destroy(other.gameObject); // Destroys the object it collides with (the blaster bolt)
        }
        //Explosion();
        //ScoreManager.IncreaseScore(scoreToGive); //Increase score
    }
    // VoidExplosion()
}
