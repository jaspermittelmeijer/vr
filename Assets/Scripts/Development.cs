using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Development : MonoBehaviour
{

//	public string thePlatform;
	public bool visualDebug;
	public Text UI_Debug2d_text;


	// Use this for initialization
	void Start ()
	{


		// Call script to apply settings that depend on platform (eg touch vs mouse)
		if (!applyPlatformSettings ())
			debugMessage ("Platform settings failed", 3.0f);







	}
	
	// Update is called once per frame
	void Update ()
	{
	

		// Call counter script for onscreen debug messages
		if (debugCounter ()) {
			debugMessage ("", -1.0f);
		}


	}

	bool applyPlatformSettings ()
	{
		switch (Application.platform) {
			
		case RuntimePlatform.OSXEditor:
			debugMessage ("Running in os x editor", 5.0f);
//			thePlatform = "Editor";
			
			break;
			
		case RuntimePlatform.OSXPlayer:
			debugMessage ("Running in os x player", 5.0f);
//			thePlatform = "Standalone os x";
			
			break;
			
			
			
		}

		return true;
	}

	private float c;

	private bool debugCounter ()
	{
		bool returnValue;
		returnValue = false;

		if (c > 0) {
			c = c - Time.deltaTime;
			if (c < 0) {
				returnValue = true;
			}
		} 
		return returnValue;
	}

	public void debugMessage (string theMessage, float theTime)
	{
		Debug.Log (theMessage);

		if (visualDebug) {
			UI_Debug2d_text.text = theMessage;
			c = theTime;
		}
	}
}
