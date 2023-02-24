using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Store the score value.
    public int amount = 1;

    public TextMeshProUGUI scoreText; //Reference the text UI element to change.

    public void IncreaseScore(int amount)
    {
        score += amount; // Add amount to the score
        UpdateScoreText(); // Update the score UI text
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; //  Subtract amount fromt the score.
        UpdateScoreText(); //Update the score UI text.
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}