using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score = 0; // This variable is to keep track of the game score.
    public TextMeshProUGUI scoreText;



    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount) // The integer in here is only used inside this funtion.
    {
        score += amount;
        UpdateScoreText();
    }


    public void DecreaseScoreText(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "score: " + score;
    }

}
