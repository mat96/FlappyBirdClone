using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

    // Use this for initialization

    [SerializeField] GameObject rocks;
    int score = -3;

	void Start () {

        InvokeRepeating("CreateObsticles", 1f, 1.5f);
	}
	
    void CreateObsticles() {
         
        Instantiate(rocks);
        score++;

        
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());
    }
 

}
