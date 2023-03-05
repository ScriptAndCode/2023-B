using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    private AudioSource audioSourceGameOver;
    public AudioClip gameOverClip;
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        audioSourceGameOver = GameObject.Find("AudioSource-GameOver").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame(); // Start the EndGame function below.
        }
        else
            gameOverText.gameObject.SetActive(false); // Keep UI text Game Over hidden.
    }
    public void EndGame()
    {
        audioSourceGameOver.PlayOneShot(gameOverClip, 1.0f);
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
        StartCoroutine(ReturnToMenu()); // Source: https://docs.unity3d.com/ScriptReference/WaitForSecondsRealtime.html
    }
    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(0);
    }
}
