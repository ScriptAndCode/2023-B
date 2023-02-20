using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    // An array to hold the different enemy spaceships:
    public GameObject[] enemyPrefabs;

    // [SerializeField]
    private float spawnRangeX = 17.0f;
    // [SerializedField]
    private float spawnPosZ = 21.0f;

    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    void SpawnRandomEnemy()
    {
        // Generate a position to spawn at:
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // Pick a random enemy/ufo from the array
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);// Randomly picking a ufo from the array.
        // Spawn ufos, using the enemyIndex variable to specify which one:
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
