using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Store the score value.
                          //  private int amount = 1;
    private int shield = 100; // Store the shield value.
                              // private int shieldIncrease = 1;
                              // private int shieldDecrease = 1;
    public TextMeshProUGUI scoreText; //Reference the text UI element to change.
    public TextMeshProUGUI shieldText;
    public GameManager gameManager;
    void start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
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
        // End game if shield is equal to or less than 0:
        /* if (shield <= 0)
         {
             //gameManager.isGameOver = true;
         }
         */
        UpdateShieldText();
    }
    public void UpdateShieldText()
    {
        shieldText.text = "Shield: " + shield;
    }
}