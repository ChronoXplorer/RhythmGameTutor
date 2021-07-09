using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;

    public bool songStart;

    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!songStart)
        {
            if(Input.anyKeyDown)
            {
                songStart = true;
            }
        }
        else
        {
            transform.position += new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
        
    }
}
