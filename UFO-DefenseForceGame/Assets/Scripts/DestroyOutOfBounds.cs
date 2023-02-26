using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 22.00f;
    public float lowerBounds = -20.00f;

    public ScoreManager scoreManager; // Reference the score manager so that the score can be updated.
    public DetectCollision detectCollision;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Getting the component ScoreManager script.
        detectCollision = GameObject.Find("DetectCollision").GetComponent<DetectCollision>(); // Getting the component DetectCollisions.
    }
    void Awake()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBounds)
        {
            //Everytime a ship sneeks past the lower bounds deduct points:
            if (gameObject.CompareTag("EnemyUFO"))
            {
                scoreManager.DecreaseScore(scoreManager.amount); // DecreaseScore is a funtion in the DetectCollision script.
                Debug.Log("Game Over");
                Destroy(gameObject);
                Time.timeScale = 0;
            }

            Destroy(gameObject);
        }
    }
}
