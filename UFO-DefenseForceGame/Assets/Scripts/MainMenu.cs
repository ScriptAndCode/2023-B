using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private int sceneToLoad;
    private AudioSource audioSourceClick;
    public AudioClip clickClip;

    void Start()
    {
        audioSourceClick = GameObject.Find("AudioSource-Click").GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        audioSourceClick.PlayOneShot(clickClip, 1.0f);
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        audioSourceClick.PlayOneShot(clickClip, 1.0f);
        Application.Quit();
        Debug.Log("you have quit the game, goodby!");
    }
}
