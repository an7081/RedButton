using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class NewButtonLog : MonoBehaviour
{
    public Text buttonLog;
    private float textScroll;
    private Color textAlpha;

	void Start ()
	{

	    buttonLog = GetComponent<Text>();
	    textScroll = -210.06f;
	    textAlpha.a = 255;
	    textAlpha.r = 255;
	    textAlpha.g = 255;
	    textAlpha.b = 255;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    textScroll+= 0.6f;
        buttonLog.rectTransform.localPosition = new Vector2(-316, textScroll);

	    if (textScroll >= -70)
	    {
	        textAlpha.a /= 2;
	        buttonLog.color = textAlpha;
	    }
        if (textScroll >= 0)
        {
            Destroy(this.gameObject);
        }
        if (Input.anyKeyDown)
        {
            textScroll += 15;
            //buttonStatus();
        }

        //print(alphaColor);

	}
    void buttonStatus()
    {
        //buttonLog.text = "TEST TEST TEST";

    }
}




