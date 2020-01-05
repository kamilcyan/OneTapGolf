using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo)
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
}
