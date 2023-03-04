using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Store the score value.
    public int amount = 1;
    public int shield = 100; // Store the shield value.
    public int shieldIncrease = 1;
    public int shieldDecrease = -5;

    public TextMeshProUGUI scoreText; //Reference the text UI element to change.
    public TextMeshProUGUI shieldText;


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


    public void IncreaseShield(int shieldIncrease)
    {
        shield += shieldIncrease;
        UpdateShieldText();
    }

    public void DecreaseShield(int shieldDecrease)
    {
        shield -= shieldDecrease;
        UpdateShieldText();
    }

    public void UpdateShieldText()
    {
        shieldText.text = "Shield: " + shield;
    }

}