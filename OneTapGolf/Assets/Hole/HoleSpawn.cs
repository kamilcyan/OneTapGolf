using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpawn : MonoBehaviour {

    public GameObject objectHole;
    public float spawnX = 6f;

	// Use this for initialization
	void Start () {
        Spawn();
	}

    // Update is called once per frame
    void Spawn()
    {
        float random = Random.Range(-spawnX, spawnX);
        Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
        Instantiate(objectHole, spawnPos, Quaternion.identity);

        Invoke("Spawn", Random.Range(-1, 10));
    }
}
