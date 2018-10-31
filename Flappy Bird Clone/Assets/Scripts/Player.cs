using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    
    [SerializeField] Vector2 jumpForce = new Vector2(0, 300);

    Rigidbody2D Rigidbody;
	// Use this for initialization
	void Start ()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.velocity = Vector2.zero;
            Rigidbody.AddForce(jumpForce);
        }
	}
}
