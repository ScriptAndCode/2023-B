using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 50.00f;
    public float xRange = 25.00f;
    public Transform blaster;
    public GameObject laserBolt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Set horizontalInput to recieve values from keyboard:
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right:
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //  Keep player within bounds, left side:
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //  Keep player within bounds, right side:
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // If space bar is pressed, fire laserBolt:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Create lasberBolt at the blaster location:
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }
}
