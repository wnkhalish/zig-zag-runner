using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreHolder : MonoBehaviour
{
    public static int score;
    public Text scoreText;
    public Text finalScoreText;
    public Text bestScoreText;

    public int timeOfGame;
    public float timer;

    public Text timeText;
  

    private static string playerName;

    void Start()
    {
        timer = 0.0f;
        timeOfGame = 0;
        Time.timeScale = 1;
        score = 0;
    }


    private void Update()
    {
        ShowScore();
       // UpdateTime();
    }

    public void AddToScore(int amount) => score += amount;

    public int GetScore() => score;

    public void ShowScore() => scoreText.text = score.ToString();

    public void GameOver()
    {
        // Time.timeScale = 0;
        finalScoreText.text = score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScoreDisplay", 0);

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScoreDisplay", score);
        }
        bestScoreText.text = PlayerPrefs.GetInt("BestScoreDisplay", 0).ToString();

    }

 /*   void UpdateTime()
    {
        if (isPlaying)
        {
            timer += Time.deltaTime;
            timeOfGame = Convert.ToInt32(timer);
        }
        timeText.text = "Time: " + FormatTimeText();
    }


    string FormatTimeText()
    {
        return (timeOfGame.ToString()).PadLeft(3, ' ') + "s";
    }*/
    public static string getPlayerName()
    {
        return playerName;
    }

    public static void SetPlayerName(string _playerName)
    {
        playerName = _playerName;
    }



}