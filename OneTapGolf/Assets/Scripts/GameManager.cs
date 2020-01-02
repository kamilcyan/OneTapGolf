﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text scoreText;
    public Text gameOverText;

    int playerScore = 0;

    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void PlayerLost()
    {
        gameOverText.enabled = true;
        Time.timeScale = 0;
    }
}
