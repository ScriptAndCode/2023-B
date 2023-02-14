using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemMoveDown : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float lowerBound = -20.0f;

    // Start is called before the first frame update
    void Start()
    {
        // pickupItem = GetComponent<PickupItem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
