using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
	bool looking;
	GameObject theCamera;
	float rotationX = 0F;
	float rotationY = 0F;
	float sensitivityX = 15F;
	float sensitivityY = 15F;
	float smoothMouseX, smoothMouseY, mouseRawX, mouseRawY;
	Quaternion originalRotation;


	int verticeSliderValue;
	float amplitudeSliderValue,roughnessSliderValue;

	public bool visualDebug;
	public Text UI_DebugText,UI_VerticeSliderText,UI_AmplitudeSliderText,UI_RoughnessSliderText;
	Slider UI_VerticeSlider,UI_AmplitudeSlider,UI_RoughnessSlider;
//	public Button buffer00, buffer01, buffer02, buffer03, buffer04;
	public Button[] bufferButtons;


//	public Button UI_VerticeButton;

	// Use this for initialization

	World world;
	Settings settings;


	void Start ()
	{
		world = GameObject.Find ("Root").GetComponent <World> ();
		settings = GameObject.Find ("Root").GetComponent <Settings> ();
		theCamera = GameObject.Find ("MainCamera");// get a reference tot he main cam


		UI_VerticeSlider = GameObject.Find ("UI_VerticeSlider").GetComponent <Slider> ();
		UI_VerticeSlider.value=settings.initialVerticeCount;
		verticeSliderChanged (settings.initialVerticeCount); 

		UI_AmplitudeSlider = GameObject.Find ("UI_AmplitudeSlider").GetComponent <Slider> ();
		UI_AmplitudeSlider.value=settings.initialAmplitude;
		amplitudeSliderChanged (settings.initialAmplitude); 

		UI_RoughnessSlider = GameObject.Find ("UI_RoughnessSlider").GetComponent <Slider> ();
		UI_RoughnessSlider.value=settings.initialRoughness;
		roughnessSliderChanged (settings.initialRoughness); 

		for (int i=1;i<5;i++){
			bufferButtons [i].gameObject.SetActive (false);
		}



	}


	
	// Update is called once per frame
	void Update ()
	{
	

		// Call counter script for onscreen debug messages
		if (debugCounter ()) {
			debugMessage ("", -1.0f);
		}

		if (Input.GetKeyDown ("m")) {
			while (world.getCurrentIsland().getDelauney().flipAllTriangles ())
				;
			Debug.Log ("Flipping triangles");

		}


		GameObject.Find ("Cube").transform.rotation = Input.gyro.attitude;



		if (Input.GetMouseButtonDown (0)) {
			//			Debug.Log("Start looking");

			looking = true;
			originalRotation = theCamera.transform.localRotation;
			rotationX = 0F;
			rotationY = 0F;
		}

		if (Input.GetMouseButtonUp (0)) {
			//			Debug.Log("Stop looking");

			looking = false;


		}



		if (looking) {


			mouseRawX = Input.GetAxisRaw ("Mouse X");
			mouseRawY = Input.GetAxisRaw ("Mouse Y");

			smoothMouseX = Mathf.Lerp (smoothMouseX, mouseRawX, 1f / 3f);
			smoothMouseY = Mathf.Lerp (smoothMouseY, mouseRawY, 1f / 3f);

			rotationX += smoothMouseX * sensitivityX;
			rotationY += smoothMouseY * sensitivityY;

			Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
			Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, -Vector3.right);

			theCamera.transform.localRotation = originalRotation * xQuaternion * yQuaternion;
			theCamera.transform.localRotation = Quaternion.Euler (theCamera.transform.eulerAngles.x, theCamera.transform.eulerAngles.y, 0f);

			//			Debug.Log(rotationX);

		}



	}
	public void bufferButtonClicked (int buffer){
		debugMessage ("Switch to buffer: " + buffer,3f);
		world.switchToIsland (buffer);
	}


	public void verticeSliderChanged (float passValue){

		UI_VerticeSliderText.text = "" + passValue;
		verticeSliderValue = Mathf.FloorToInt (passValue);

	}

	public void amplitudeSliderChanged (float passValue){

		UI_AmplitudeSliderText.text = "" + passValue;
		amplitudeSliderValue = passValue;

	}

	public void roughnessSliderChanged (float passValue){

		UI_RoughnessSliderText.text = "" + passValue;
		roughnessSliderValue = passValue;

	}


	public void deleteIslandButtonClicked (){

		if (world.getNumberOfIslands () > 1) {
			bufferButtons [world.getCurrentBufferSize ()-1 ].gameObject.SetActive (false);
			world.deleteCurrentBuffer();
			debugMessage ("Deleted island", 5f);

		}

	}

	public void spawnButtonClicked (){


		if (world.getNumberOfIslands() < 5) {
			world.addNewIsland (verticeSliderValue, amplitudeSliderValue, roughnessSliderValue);
			debugMessage ("Created new island", 5f);
			bufferButtons [world.getNumberOfIslands () - 1].gameObject.SetActive (true);
		}


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
			UI_DebugText.text = theMessage;
			c = theTime;
		}
	}
}
