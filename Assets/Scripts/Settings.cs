using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

	public string thePlatform;
	public bool visualDebug;
	public int initialVerticeCount = 90;
	public float initialAmplitude = 3f;
	public float initialRoughness = 0.7f;
	public Color lineColor01;

//	public Text UI_Debug2d_text;

Interaction interaction;


//	GameObject interactionObject;

//	private Component interaction;


	// Use this for initialization
	void Start ()
	{

		interaction = GameObject.Find ("Root").GetComponent <Interaction> ();



		// Call script to apply settings that depend on platform (eg touch vs mouse)
		if (!applyPlatformSettings ())
			interaction.debugMessage ("Platform settings failed", 3.0f);


	




	}
	
	// Update is called once per frame
	void Update ()
	{
	



	}

	bool applyPlatformSettings ()
	{
		switch (Application.platform) {
			
		case RuntimePlatform.OSXEditor:
			interaction.debugMessage ("Running in os x editor", 5.0f);
		thePlatform = "Editor";
			
			break;
			
		case RuntimePlatform.OSXPlayer:
			interaction.debugMessage ("Running in os x player", 5.0f);
			thePlatform = "StandaloneOsX";
			
			break;

		case RuntimePlatform.WebGLPlayer:
			interaction.debugMessage ("Running in WebGLPlayer", 5.0f);
					thePlatform = "WebGL";

			break;


			
			
		}

		return true;
	}


}
