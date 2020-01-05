using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawn : MonoBehaviour {

    public GameObject objectBall;

    // Use this for initialization
    void Start () {
        Create();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Create()
    {
        Vector3 spawnPos = transform.position; ;
        Instantiate(objectBall, spawnPos, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Create();
    }
}
