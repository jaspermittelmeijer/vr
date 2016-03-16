using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

public class World : MonoBehaviour
{
	public GameObject debugObject;
	GameObject delauneyObject01, terrainObject01;
	Delauney delauney01;

	bool looking;
	GameObject theCamera;
	float rotationX = 0F;
	float rotationY = 0F;
	 float sensitivityX = 15F;
	 float sensitivityY = 15F;
	public Color lineColor01 ;


	Material mat;
	float smoothMouseX, smoothMouseY, mouseRawX, mouseRawY;


	Quaternion originalRotation;


	// Use this for initialization
	void Start ()
	{
		


	mat = Resources.Load ("Colour01") as Material;
		GameObject.Find ("Cube").GetComponent<Renderer>().material = mat;







	


		RandomTerrain theTerrain = new RandomTerrain (10.0f, 4, 3.0f, 0.7f);

		terrainObject01 = new GameObject ("Terrain 01");
		terrainObject01.transform.parent = transform;
		terrainObject01.AddComponent<MeshFilter> ();
		terrainObject01.AddComponent<MeshRenderer> ();

		terrainObject01.AddComponent<CustomRender> ();



		Mesh mesh = new Mesh ();
		terrainObject01.GetComponent<MeshFilter> ().mesh = mesh;

		mesh.vertices = theTerrain.getVertices ();
		mesh.triangles = theTerrain.getTriangles ();
		mesh.RecalculateNormals ();
		terrainObject01.GetComponent <CustomRender> ().CreateLinesFromMesh ();

		terrainObject01.GetComponent<Renderer>().material = mat;
		terrainObject01.GetComponent<CustomRender> ().passColor(lineColor01);
		terrainObject01.SetActive (false);

		/*
		Vector3 testpoint = new Vector3 (Random.Range (0.0f, 1000.0f), 0.0f, Random.Range (0.0f, 1000.0f));
		testpoint.y = theTerrain.getHeight (testpoint.x, testpoint.z);

		Debug.Log ("Testpoint " + testpoint.x + " " + testpoint.y + " " + testpoint.z);


			
		GameObject.Find ("VisualDebug").GetComponent <VisualDebug> ().addDebugPoint (testpoint, new Color (1.0f, 1.0f, 1.0f), 5.0f);
*/

		theCamera = GameObject.Find ("MainCamera");

		Vector3 cameraPosition = new Vector3 (Random.Range (0.0f, 10.0f), 0.0f, Random.Range (0.0f, 10.0f));
	cameraPosition.y = theTerrain.getHeight (cameraPosition.x, cameraPosition.z)+1f;

		theCamera.transform.position = cameraPosition;

		theCamera.transform.localRotation = Quaternion.LookRotation (new Vector3 (5f, 0f, 5f) - theCamera.transform.position, Vector3.up);


	


		delauney01 = new Delauney ();
		delauney01.createDelauney (100, 10.0f, theTerrain);


		delauneyObject01 = new GameObject ("Delauney 01");
		delauneyObject01.transform.parent = transform;

		delauneyObject01.AddComponent<MeshFilter> ();
		delauneyObject01.AddComponent<MeshRenderer> ();

		delauneyObject01.AddComponent<CustomRender> ();

		mesh = new Mesh ();
		delauneyObject01.GetComponent<MeshFilter> ().mesh = mesh;

		mesh.vertices = delauney01.getVertices ();
		mesh.triangles = delauney01.getTriangles ();
//		mesh.triangles = mesh.triangles.Reverse ();
		mesh.RecalculateNormals ();

		delauneyObject01.GetComponent<CustomRender> ().passColor(lineColor01);

//		mesh.normals = mesh.normals.Select(o -> -o).ToArray();


		delauneyObject01.GetComponent <CustomRender> ().CreateLinesFromMesh ();
		delauneyObject01.GetComponent<Renderer>().material = mat;


		delauneyObject01 = new GameObject ("Delauney 01 back");
		delauneyObject01.transform.parent = transform;

		delauneyObject01.AddComponent<MeshFilter> ();
		delauneyObject01.AddComponent<MeshRenderer> ();


		mesh = new Mesh ();
		delauneyObject01.GetComponent<MeshFilter> ().mesh = mesh;

		mesh.vertices = delauney01.getVertices ();
		mesh.triangles = delauney01.getTriangles ();
		//		mesh.triangles = mesh.triangles.Reverse ();
		mesh.RecalculateNormals ();

		mesh.triangles = mesh.triangles.Reverse ().ToArray ();

		delauneyObject01.GetComponent<Renderer>().material = mat;
//		delauneyObject01.GetComponent<CustomRender> ().passColor(lineColor01);



		//		mesh.normals = mesh.normals.Select(o -> -o).ToArray();











	



	}




	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown ("m")) {
			while (delauney01.flipAllTriangles ())
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






		/*
		Mesh mesh = new Mesh ();
		delauneyObject01.GetComponent<MeshFilter> ().mesh = mesh;
		
		mesh.vertices = delauney01.getVertices();
		mesh.triangles = delauney01.getTriangles();
		mesh.RecalculateNormals();
		delauneyObject01.GetComponent <CustomRender> ().CreateLinesFromMesh ();
	*/
	}


}
