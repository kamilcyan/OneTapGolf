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



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            timer += Time.deltaTime;
            Hit(timer);
        }
        
    }

    void Hit(float speedUper)
    {
        
        speed += speedUper;
        rb.velocity = transform.right * speed;

    }



    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        
        Destroy(objectBall);
    }
}
