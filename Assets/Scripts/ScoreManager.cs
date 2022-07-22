using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text scoreResult;
    public Text highScoreText;
    public float scoreAmount;
    public float scorePerSecond;

    private void Start()
    {
        scoreAmount = 0;
    }

    private void Update()
    {
        scoreText.text = "Score : " + (int)scoreAmount;
        scoreResult.text = "Your Score: " + (int)scoreAmount;
        scoreAmount += scorePerSecond * Time.deltaTime;
        CheckHighScore();
        UpdateHighScoreText();

    }

    void CheckHighScore()
    {
        if (scoreAmount>PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", ((int)scoreAmount));
        }
    }


   public void UpdateHighScoreText()
    {
        highScoreText.text= $"Highest Score: {PlayerPrefs.GetInt("HighScore",0) }";
    }

}
