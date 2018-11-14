using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreLabel : MonoBehaviour {
    [SerializeField] GameObject scoreObject;
    ScoreKeeper scoreKeeper;
    Text textBox;
    //int score;
	// Use this for initialization
	void Start ()
    {
        scoreKeeper = scoreObject.GetComponent<ScoreKeeper>();
        textBox = GetComponent<Text>();

        

    }

    void Update()
    {
       // Debug.Log(scoreKeeper.score);
        //textBox.text = "Your last score was: " + score;
    }

}
