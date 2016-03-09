using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour
{
	public GameObject debugObject;
	GameObject delauneyObject01;
	Delauney delauney01;

	// Use this for initialization
	void Start ()
	{

		delauneyObject01 = new GameObject ("Delauney 01");
		delauneyObject01.transform.parent = transform;
		
		delauneyObject01.AddComponent<MeshFilter> ();
		delauneyObject01.AddComponent<MeshRenderer> ();

		delauneyObject01.AddComponent<CustomRender> ();


		delauney01 = new Delauney ();
		StartCoroutine(delauney01.createDelauney (30,500.0f));




	



	}



	// Update is called once per frame
	void Update ()
	{
		Mesh mesh = new Mesh ();
		delauneyObject01.GetComponent<MeshFilter> ().mesh = mesh;
		
		mesh.vertices = delauney01.getVertices();
		mesh.triangles = delauney01.getTriangles();
		mesh.RecalculateNormals();
		delauneyObject01.GetComponent <CustomRender> ().CreateLinesFromMesh ();
	
	}
}
