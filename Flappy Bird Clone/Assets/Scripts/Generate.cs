using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {


    [SerializeField] GameObject rocks;
    [SerializeField] GameObject enemy;

	void Start () {

        InvokeRepeating("SpawnRocks", 1f, 1.5f);
        InvokeRepeating("SpawnEnemy", 1f, 2.5f);
    }
	
    void SpawnRocks() {
         
        Instantiate(rocks);        
    }

    void SpawnEnemy()
    {
        Instantiate(enemy);
    }
    private void OnGUI()
    {
        GUI.color = Color.black;
        
    }
 

}
