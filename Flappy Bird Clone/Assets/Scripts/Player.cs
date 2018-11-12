using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    
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
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.velocity = Vector2.zero;
            Rigidbody.AddForce(jumpForce);
        }
        // Die by being offscreen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y <0)
        {
           Die();

        }

    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        SceneManager.LoadScene(0);
    }


}
