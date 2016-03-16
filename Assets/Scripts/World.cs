using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

public class World : MonoBehaviour
{
	public GameObject debugObject;
	GameObject delauneyObject01, terrainObject01;
	Delauney delauney01;

	// Use this for initialization
	void Start ()
	{
		RandomTerrain theTerrain = new RandomTerrain (10.0f, 4, 5.0f, 0.7f);

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


		/*
		Vector3 testpoint = new Vector3 (Random.Range (0.0f, 1000.0f), 0.0f, Random.Range (0.0f, 1000.0f));
		testpoint.y = theTerrain.getHeight (testpoint.x, testpoint.z);

		Debug.Log ("Testpoint " + testpoint.x + " " + testpoint.y + " " + testpoint.z);


			
		GameObject.Find ("VisualDebug").GetComponent <VisualDebug> ().addDebugPoint (testpoint, new Color (1.0f, 1.0f, 1.0f), 5.0f);
*/





	


		delauney01 = new Delauney ();
	    delauney01.createDelauney (50,10.0f,theTerrain);


		delauneyObject01 = new GameObject ("Delauney 01");
		delauneyObject01.transform.parent = transform;

		delauneyObject01.AddComponent<MeshFilter> ();
		delauneyObject01.AddComponent<MeshRenderer> ();

		delauneyObject01.AddComponent<CustomRender> ();

		mesh = new Mesh ();
		delauneyObject01.GetComponent<MeshFilter> ().mesh = mesh;

		mesh.vertices = delauney01.getVertices();
		mesh.triangles = delauney01.getTriangles();
//		mesh.triangles = mesh.triangles.Reverse ();
		mesh.RecalculateNormals();


//		mesh.normals = mesh.normals.Select(o -> -o).ToArray();


		delauneyObject01.GetComponent <CustomRender> ().CreateLinesFromMesh ();



		delauneyObject01 = new GameObject ("Delauney 01 back");
		delauneyObject01.transform.parent = transform;

		delauneyObject01.AddComponent<MeshFilter> ();
		delauneyObject01.AddComponent<MeshRenderer> ();



		mesh = new Mesh ();
		delauneyObject01.GetComponent<MeshFilter> ().mesh = mesh;

		mesh.vertices = delauney01.getVertices();
		mesh.triangles = delauney01.getTriangles();
		//		mesh.triangles = mesh.triangles.Reverse ();
		mesh.RecalculateNormals();

		mesh.triangles = mesh.triangles.Reverse().ToArray();



		//		mesh.normals = mesh.normals.Select(o -> -o).ToArray();











	



	}



	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown ("m")) {
			while (delauney01.flipAllTriangles ());
			Debug.Log ("Flipping triangles");

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
