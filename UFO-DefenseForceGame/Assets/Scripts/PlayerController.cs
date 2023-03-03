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
    public int numbOfPickup = 0;
    public GameManager gameManager;
    // Audio Variables
    private AudioSource blasterAudio; // Where the audio is located?
    public AudioClip laserBlast; // The audio itself?

    void Start()
    {

        blasterAudio = GetComponent<AudioSource>(); // since on same gameObject, just the component needs to be found, not the game object.

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

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
        // Two conditions must be met to fire laser bolt:
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            blasterAudio.PlayOneShot(laserBlast, 1.0F); //Play blasterAudio sound clip.
            // Create lasberBolt at the blaster location:
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }

    // Delete any object with a trigger that hits the player:
    void OnTriggerEnter(Collider other)
    {
        // count number of pickup items collected:
        if (other.gameObject.CompareTag("PickupItem"))
        {
            numbOfPickup += 1;
            Debug.Log("Number of collectables: " + numbOfPickup);
        }
        Destroy(other.gameObject);
    }
}