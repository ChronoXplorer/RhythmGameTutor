using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool musicStart;

    public BeatScroller beatScroll;

    public static GameManager instance;
    
    void Start()
    {
        instance = this;
    }
    
    void Update()
    {
        if(!musicStart)
        {
            if(Input.anyKeyDown)
            {
                musicStart = true;
                beatScroll.songStart = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Perfect!");
    }

    public void NoteMiss()
    {
        Debug.Log("MISS");
    }
}
