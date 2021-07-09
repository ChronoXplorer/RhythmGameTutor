using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer sRender;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress; //the key button that used to pressed
     
    void Start()
    {
        sRender = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            sRender.sprite = pressedImage;
        }

        if(Input.GetKeyUp(keyToPress))
        {
            sRender.sprite = defaultImage;
        }
    }
}