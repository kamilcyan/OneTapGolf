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
    public HittingBall hittingBall;


    float playerScore = 0;
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
        objectBall = hittingBall.GetComponent<GameObject>();
        if()
        gameOverText.enabled = true;
        Time.timeScale = 0;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
         
        Debug.Log(collider.name);
        AddScore();
    }
}
