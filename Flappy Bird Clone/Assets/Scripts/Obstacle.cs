using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    Rigidbody2D Rigidbody;
    [SerializeField] Vector2 velocity = new Vector2(-4, 0);
    [SerializeField] float range = 4; 
	// Use this for initialization
	void Start () {

        
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.velocity = velocity;

        //Creates randomness in the obstacles
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value,
            transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

        // Die by being offscreen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x > Screen.width || screenPosition.x < 0)
        {
            Invoke("selfDestruct", 3f);
        }

    }


    void selfDestruct()
    {
        Destroy(gameObject);
    }
}
