using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingBall : MonoBehaviour {

    public Transform firePoint;
    public GameObject objectBall;
    public float speed = 10f;
    public Rigidbody2D rb;
    public float timer = 0f;
    public Transform spawnPos;
    GameManager gameManager;
    ifIsGrounded ifIsGrounded;

    void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        Timer();
    }

    void Timer()
    {
        ifIsGrounded = GameObject.FindObjectOfType<ifIsGrounded>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            timer = Time.time;

        }
        if (Input.GetKeyUp(KeyCode.Space)&& ifIsGrounded.isGrounded)
        {
            float timer2 = Time.time - timer;
            Hit(timer2);
        }
    }

    void Hit(float speedUper)
    {
        speed = speedUper * 10;
        rb.velocity = transform.right * speed;
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        if (collider.name != "Shredder" && collider.name != "Shredder (1)")
        {
            
            gameManager.AddScore();
            Destroy(objectBall);
            gameManager.Create();
            
        }
        else
            gameManager.PlayerLost();
    }

    
}
