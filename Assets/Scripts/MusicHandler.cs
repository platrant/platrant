﻿using UnityEngine;
using System.Collections;

public class MusicHandler : MonoBehaviour {

    //Singleton to ensure restarting the scene doesn't cause a new music player.
    static MusicHandler instance = null;

    //Doing singleton management in Awake rather than start to ensure
    //that a second music player won't be heard for a split second when
    //starting the game
    void Awake ()
    {
        if(instance != null){
            Destroy(gameObject);   
        } else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
