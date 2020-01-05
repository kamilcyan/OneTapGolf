using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text scoreText;
    public Text gameOverText;


    float playerScore = 0;
    private void Update()
    {
        AddScore();
    }
    public void AddScore()
    {
        playerScore+=Time.deltaTime;
        scoreText.text = playerScore.ToString();
    }

    public void PlayerLost()
    {
        gameOverText.enabled = true;
        Time.timeScale = 0;
    }
}
