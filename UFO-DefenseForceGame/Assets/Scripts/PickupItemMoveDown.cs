using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemMoveDown : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
