using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject objectHole;
    public float spawnX = 6f;
    HittingBall hittingBall;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider)
        {
            Destroyer();
        }
    }

        // Update is called once per frame
    void Update () {

    }

    void Destroyer()
    {
        Destroy(this.gameObject);

        //Spawn();
    }

    public void Spawn()
    {
        hittingBall = GameObject.FindObjectOfType<HittingBall>();
        float random = Random.Range(-spawnX, spawnX);
        Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
        Instantiate(objectHole, spawnPos, Quaternion.identity);
        hittingBall.Update();
    }

}
