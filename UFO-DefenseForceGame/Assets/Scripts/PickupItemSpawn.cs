using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemSpawn : MonoBehaviour
{
    public GameObject pickupItem;
    public float xSpawnRange = 20.0f;
    public float zSpawnPos = 20;
    public float ySpawnPos = 2.0f;
    public float spawnInterval = 1.0f;
    public float startDelay = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPickupItem", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnPickupItem()
    {
        // Creating a random location in the X range to spawn:
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos, zSpawnPos);

        Instantiate(pickupItem, spawnPos, pickupItem.transform.rotation);
    }
}
