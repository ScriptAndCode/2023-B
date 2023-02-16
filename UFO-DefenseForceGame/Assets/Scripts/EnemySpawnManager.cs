using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    // An array to hold the different enemy spaceships:
    public GameObject[] enemyPrefabs;

    // [SerializeField]
    //  private float spawnRangeX = 17.0f;

    // [SerializedField]
    private float spawnPosZ;

    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    /*
     void SpawnRandomEnemy()
     {
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
         int enemyIndex = NonRandomizedStringEqualityComparer.Range(0,)
     }
     */
}
