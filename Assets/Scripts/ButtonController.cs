using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer sRender;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress; //the key button that used to pressed
     
    // Start is called before the first frame update
    void Start()
    {
        sRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
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