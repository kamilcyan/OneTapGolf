using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawn : MonoBehaviour {

    public GameObject objectBall;
    public Transform spawnPos;

    // Use this for initialization
    void Start () {
        Create();
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void Create()
    {
        Instantiate(objectBall, spawnPos.position, spawnPos.rotation);
    }
}
