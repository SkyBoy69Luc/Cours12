using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    public void Start()
    {
        int numberOfMusicPlays = FindObjectsOfType<MusicPlayer>().Length;

        if (numberOfMusicPlays > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }


    }

}
