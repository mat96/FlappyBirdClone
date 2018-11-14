using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
    int currentSceneIndex;
    int score;
    [SerializeField] GameObject scoreLabel;
    Text textBox;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        //So music player doesnt duplicate upon menu screen
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(this.gameObject);
        }
    }

    void OnEnable()
    {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled.
        //Remember to always have an unsubscription for every delegate you subscribe to!

        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {

        if(scene.buildIndex == 1)
        {
            score = 0;
            InvokeRepeating("incrementScore", 5.5f, 1.6f);
        }


        //Debug.Log("Level Loaded");
        //Debug.Log(scene.name);
        //  Debug.Log(scene.buildIndex);
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());
    }
    void incrementScore() { score++; }
    public int getScore() { return score; }

}
