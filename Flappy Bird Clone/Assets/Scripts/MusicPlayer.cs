using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    void Awake()
    {
        //Prevents music from being destroyed on load screen
        DontDestroyOnLoad(this.gameObject);


        //So music player doesnt duplicate upon menu screen
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(this.gameObject);
        }
    }

}
