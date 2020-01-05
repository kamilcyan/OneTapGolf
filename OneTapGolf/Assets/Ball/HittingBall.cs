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



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timer = Time.time;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            float timer2 = Time.time - timer;
            Hit(timer2);
        }
    }

    void Hit(float speedUper)
    {
        speed += speedUper;
        rb.velocity = transform.right * speed;
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(objectBall);
        Create();
    }

    void Create()
    {
        Instantiate(objectBall, spawnPos.position, spawnPos.rotation);
    }
}
