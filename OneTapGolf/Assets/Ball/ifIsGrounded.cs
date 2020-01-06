using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifIsGrounded : MonoBehaviour
{
    public bool isGrounded;
    public LayerMask groundLayers;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // sprawdzanie czy obiekt jest na ziemi, wtedy możmna znów uderzyć
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f), new Vector2(transform.position.x + 0.5f, transform.position.y - 0.51f), groundLayers);
    }
}
