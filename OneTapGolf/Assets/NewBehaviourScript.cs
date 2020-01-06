using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject objectHole;
    public float spawnX = 6f;
    HittingBall hittingBall;
    SpawnPosition spawnPosition;

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
    }

    public void Spawn()
    {
        hittingBall = GameObject.FindObjectOfType<HittingBall>();
        spawnPosition = GameObject.FindObjectOfType<SpawnPosition>();
        Vector3 position = spawnPosition.pos;

        float random = Random.Range(-spawnX, spawnX);
        Vector3 spawnPos = position + new Vector3(random, -3.65f, 0f);
        Instantiate(objectHole, spawnPos, Quaternion.identity);

        hittingBall.Update();
    }

}
