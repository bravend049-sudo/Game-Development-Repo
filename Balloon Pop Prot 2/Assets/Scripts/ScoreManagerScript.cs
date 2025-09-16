using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagerScript : MonoBehaviour
{

    public int score;
    public TextMeshProGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; //Increase Score by Amount
        UpdateScoreText();
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount; //Decrease Score by Amount
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.Text = "Score: " + score;
    }
}
