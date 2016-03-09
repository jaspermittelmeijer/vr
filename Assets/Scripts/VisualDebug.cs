﻿using UnityEngine;
using System.Collections;

public class VisualDebug: MonoBehaviour
{

	public GameObject target;

	void Start ()
	{

//		addDebugPoint (new Vector3 (50.0f, 0.0f, 0.0f), new Color (1.0f, 1.0f, 1.0f));

	}

	void Update ()
	{
	}

	public GameObject addDebugPoint (Vector3 point, Color color, float scaling)
	{

		GameObject visualDebugPoint = new GameObject ("Debugpoint 01");
		visualDebugPoint.transform.parent = transform;
		visualDebugPoint.transform.position = point;


//		GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
//		sphere.transform.position = point;
		visualDebugPoint.AddComponent<MeshFilter> ();
		visualDebugPoint.AddComponent<MeshRenderer> ();
		visualDebugPoint.AddComponent<CustomRender> ();

		Mesh mesh = new Mesh ();
		visualDebugPoint.GetComponent<MeshFilter> ().mesh = mesh;

		Vector3[] vertices = new Vector3[5];

		vertices [0] = new Vector3 (0.0f, 0.0f, 10.0f);
		vertices [1] = new Vector3 (7.0f, 0.0f, -7.0f);
		vertices [2] = new Vector3 (-7.0f, 0.0f, -7.0f);
		vertices [3] = new Vector3 (0.0f, 7.0f, 0.0f);
		vertices [4] = new Vector3 (0.0f, -7.0f, 0.0f);

		int[] triangles = new int[3 * 6 ];
		triangles [0] = 0;
		triangles [1] = 1;
		triangles [2] = 3;

		triangles [3] = 1;
		triangles [4] = 0;
		triangles [5] = 4;

		triangles [6] = 1;
		triangles [7] = 2;
		triangles [8] = 3;

		triangles [9] = 2;
		triangles [10] = 1;
		triangles [11] = 4;

		triangles [12] = 2;
		triangles [13] = 0;
		triangles [14] = 3;

		triangles [15] = 0;
		triangles [16] = 2;
		triangles [17] = 4;





		mesh.vertices = vertices;
		//			mesh.uv = newUV;
		mesh.triangles = triangles;
		visualDebugPoint.transform.localScale = new Vector3(scaling,scaling,scaling);

		visualDebugPoint.GetComponent <CustomRender> ().CreateLinesFromMesh ();

		return (visualDebugPoint); // return a reference to the created gameobject

	}





}