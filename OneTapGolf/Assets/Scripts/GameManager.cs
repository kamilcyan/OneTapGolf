using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text scoreText;
    public Text gameOverText;
    public GameObject objectBall;
    public Transform spawnPos;
    public GameObject objectHole;
    GameManager gameManager;
    NewBehaviourScript newBehaviourScript;

    
    int playerScore = 0;

    private void Update()
    {

    }
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

    public void Create()
    {
        newBehaviourScript = GameObject.FindObjectOfType<NewBehaviourScript>();
        Instantiate(objectBall, spawnPos.position, spawnPos.rotation);
        newBehaviourScript.Spawn();
    }
}
