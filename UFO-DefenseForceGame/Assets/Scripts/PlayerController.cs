using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 50.00f;
    public float xRange = 25.00f;
    public Transform blaster;
    //Referencing scripts
    private GameManager gameManager;
    private ScoreManager scoreManager;
    public GameObject laserBolt;
    public int numbOfPickup = 0;
    public AudioClip blasterClip; // The audio itself?
    private AudioSource audioSource;
    private AudioSource audioSourceExplosion;
    public AudioClip explosionClip;
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // since on same gameObject, just the component needs to be found, not the game object.
        audioSourceExplosion = GameObject.Find("AudioSource-Explosion").GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
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
            audioSource.PlayOneShot(blasterClip, 1.0F); //Play blasterAudio sound clip.
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation); // Creates lasberBolt at the blaster location.
        }
    }
    void OnTriggerEnter(Collider other) // Delete any object with a trigger that hits the player.
    {
        if (other.gameObject.CompareTag("PickupItem"))  // count number of pickup items collected.
        {
            numbOfPickup += 1;
            Debug.Log("Number of collectables: " + numbOfPickup);
            scoreManager.IncreaseShield(1);
        }
        if (other.gameObject.CompareTag("EnemyUFO"))
        {
            audioSourceExplosion.PlayOneShot(explosionClip, 1.0F);
            scoreManager.DecreaseShield(5);
        }
        Destroy(other.gameObject);

    }
}