using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingBall : MonoBehaviour {

    public Transform firePoint;
    public GameObject objectBall;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Hit();
        }
	}

    void Hit()
    {
        Instantiate(objectBall, firePoint.position, firePoint.rotation);
    }
}
