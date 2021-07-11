using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool musicStart;

    public BeatScroller beatScroll;
    
    void Start()
    {
        
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
}
