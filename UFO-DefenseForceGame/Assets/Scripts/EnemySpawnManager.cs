using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    // An array to hold the different enemy spaceships:
    public GameObject[] enemyPrefabs;
    [SerializeField]
    private float spawnRangeX = 17.0f;
    [SerializeField]
    private float spawnPosZ = 21.0f;
    private float startDelay = 2f;
    private float spawnInterval = 2f;
    //public int ufoIndex;


    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }


    void SpawnRandomEnemy()
    {
        // Generate a position to spawn at:
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Pick a random enemy/ufo from the array:
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        // Spawn ufos, using the enemyIndex variable to specify which one:
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

    }

    /*
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);              // Generates a random X position to spawn from.
                int enemyIndex = Random.Range(0, enemyPrefabs.Length);                                              // Picks a random UFO from the array.
                Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);       // Spawns an indexed enemy from the array.
            }
        }
        */

}
