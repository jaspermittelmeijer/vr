using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour
{

	private Vector3[] newVertices;
	private Vector2[] newUV;
	private int[] newTriangles;
	private Vector3 leg1, leg2, normal;
	private List<int> edge;

	void addTriangle (int a, int b, int c, int i)
	{

		Debug.Log ("Added triangle: " + a + " " + b + " " + c + " at: " + i);


		leg1 = newVertices [b] - newVertices [a];
		leg2 = newVertices [c] - newVertices [a];
		normal = Vector3.Cross (leg1, leg2);
		
		if (normal.y >= 0.0f) {
//			Debug.Log ("Normal pointing up");
			newTriangles [i + 0] = a;
			newTriangles [i + 1] = b;
			newTriangles [i + 2] = c;
		} else {
			
//			Debug.Log ("Normal down, swapping points");
			newTriangles [i + 0] = a;
			newTriangles [i + 1] = c;
			newTriangles [i + 2] = b;
		}


	}


	// Use this for initialization
	void Start ()
	{

		gameObject.AddComponent<MeshFilter> ();
		gameObject.AddComponent<MeshRenderer> ();
		gameObject.AddComponent<CustomRender> ();


		int numberOfVertices = 10;


		newVertices = new Vector3[numberOfVertices];

		// first 3 verices = 1 triangle. Each next vertice can generate no more than 2 additional triangles. This may be untrue
		newTriangles = new int[3 * numberOfVertices * 2 ];


		float x, y, z;

		for (int i=0; i<3; i++) {
			x = -200.0f + Random.value * 400.0f;
			y = 0.0f;
			z = -200.0f + Random.value * 400.0f;
//			Debug.Log (x +" "+z);
			newVertices [i] = new Vector3 (x, y, z);


		}


		newVertices [0] = new Vector3 (0.0f, 0.0f, 0.0f);
		newVertices [1] = new Vector3 (100.0f, 0.0f, 0.0f);
		newVertices [2] = new Vector3 (0.0f, 0.0f, 100.0f);



		// Set up the initial triangle for delauney
		addTriangle (0, 1, 2, 0);

	


		// Now start adding points, and add triangles as we go

		int n = 3;
		int triangleIndex = 3;


		while (n<numberOfVertices) {



			// Create a vertice
			x = -200.0f + Random.value * 400.0f;
			y = 0.0f;
			z = -200.0f + Random.value * 400.0f;
			newVertices [n] = new Vector3 (x, y, z);

			// Create point for our new vertice
			Point newPoint = new Point (n, newTriangles, newVertices,n);


			// Check if the point is in the mesh. If it's field of view is smaller than 180°, it is outside. If it is larger than 180°, it is inside.
			// Next, we could reject a point if it's fov is too close to 180, which'd mean it was very close to the edge.



			if (newPoint.isInConvexMesh()) {
				// Point is in the existing mesh.
				// We'll need to find the triangle it is in, delete that and split it into 3 new ones.
				Debug.Log ("Point " + n + "is in the mesh");





			} else {
				// Point is not in existing mesh. Which means we'll add triangles to connect it to all the vertices it can 'see'.

		
				int current, next, end;

				// Find out what 'visible' point is most anticlockwise, we'll start there.
				current = newPoint.getVisibleMostBackward();

				
				Debug.Log ("Start extreme back: " + current);


				// Find out what 'visible' point is most clockwise, we'll stop there.
				end = newPoint.getVisibleMostForward ();

				Debug.Log ("End extreme forward: " + end);

				

				// Create our departure point. This point is on the edge by definition, since it is the outer one 'visible' to our new point.


				while (current != end) {
					Point currentPoint = new Point (current, newTriangles, newVertices,n);
					next = currentPoint.getVisibleMostForward ();
					Debug.Log("next: "+next);

					addTriangle (current, next, n, triangleIndex);
					triangleIndex += 3;
					current = next;
				}

			}
			n++;
		}







		// 
//		Vector2 p0 = new Vector2 (newVertices [0].x, newVertices [0].z);
//		Vector2 p1 = new Vector2 (newVertices [1].x, newVertices [1].z);
//		Vector2 p2 = new Vector2 (newVertices [2].x, newVertices [2].z);
//		Vector2 pn = new Vector2 (newVertices [n].x, newVertices [n].z);



		// From our new point, we look at all other points. If the minimum angle and the maximum angle are <180 we're outside the mesh.....?







		/*

		bool connectTo0 = true;
		bool connectTo1 = true;
		bool connectTo2 = true;



		// leg a = 01, leg b = 02, leg n = 0n
		Vector2 leg01 = p1 - p0;
		Vector2 leg02 = p2 - p0;
		Vector2 leg0n = pn - p0;

		Debug.Log ("Angle between 01 and 0n: " + Vector2.Angle (leg01, leg0n));
		Debug.Log ("Angle between 0n and 02: " + Vector2.Angle (leg0n, leg02));
		Debug.Log ("Angle between 01 and 02: " + Vector2.Angle (leg01, leg02));

//		bool quadrant0 = false;

		float delta = Mathf.Abs (Vector2.Angle (leg01, leg02)) - (Mathf.Abs (Vector2.Angle (leg01, leg0n)) + Mathf.Abs (Vector2.Angle (leg0n, leg02)));
		Debug.Log ("Diff: " + delta);


		if (Mathf.Abs (delta) < 0.001F) {



			Debug.Log ("Point in quadrant 0, adding 12n triangle");
//			addTriangle (1, 2, n, triangleIndex);
			connectTo0 = false;
//			quadrant0 = true;
		}

		// leg a = 12, leg b = 10, leg n = 1n
		Vector2 leg12 = p2 - p1;
		Vector2 leg10 = p0 - p1;
		Vector2 leg1n = pn - p1;

		Debug.Log ("Angle between 12 and 1n: " + Vector2.Angle (leg12, leg1n));
		Debug.Log ("Angle between 1n and 10: " + Vector2.Angle (leg1n, leg10));
		Debug.Log ("Angle between 12 and 10: " + Vector2.Angle (leg12, leg10));




//		bool quadrant1 = false;

		delta = Mathf.Abs (Vector2.Angle (leg12, leg10)) - (Mathf.Abs (Vector2.Angle (leg12, leg1n)) + Mathf.Abs (Vector2.Angle (leg1n, leg10)));
		Debug.Log ("Diff: " + delta);

		if (Mathf.Abs (delta) < 0.001F) {

			Debug.Log ("Point in quadrant 1, adding 02n triangle");
//			addTriangle (0, 2, n, triangleIndex);
//			quadrant1 = true;
			connectTo1 = false;

		}

		// leg a = 21, leg b = 20, leg n = 2n

		Vector2 leg20 = p0 - p2;
		Vector2 leg21 = p1 - p2;
		Vector2 leg2n = pn - p2;

		Debug.Log ("Angle between 20 and 2n: " + Vector2.Angle (leg20, leg2n));
		Debug.Log ("Angle between 2n and 21: " + Vector2.Angle (leg2n, leg21));
		Debug.Log ("Angle between 20 and 21: " + Vector2.Angle (leg20, leg21));

//		bool quadrant2 = false;

		delta = Mathf.Abs (Vector2.Angle (leg20, leg21)) - (Mathf.Abs (Vector2.Angle (leg20, leg2n)) + Mathf.Abs (Vector2.Angle (leg2n, leg21)));
		Debug.Log ("Diff: " + delta);
		if (Mathf.Abs (delta) < 0.001F) {

			Debug.Log ("Point in quadrant 2, adding 01n triangle");
//			addTriangle (0, 1, n, triangleIndex);
//			quadrant2 = true;
			connectTo2 = false;
		}


		if (connectTo0) {
			Debug.Log ("Connect me to 0");
			
			
		}
		if (connectTo1) {
			Debug.Log ("Connect me to 1");
			
		}
		if (connectTo2) {
			Debug.Log ("Connect me to 2");
			
		}


		if (!connectTo0 && !connectTo1 && !connectTo2) {
			Debug.Log ("I'm in this triangle");

			// overwrite this triangle
			addTriangle (0, 1, 3, 0);

			// and add 2 additional ones
			addTriangle (3, 1, 2, triangleIndex);
			triangleIndex += 3;

			addTriangle (2, 0, 3, triangleIndex);



		} else {

			if (connectTo0 && connectTo1) {
				addTriangle (0, 1, 3, triangleIndex);
				triangleIndex += 3;

			}

			if (connectTo1 && connectTo2) {
				addTriangle (1, 2, 3, triangleIndex);
				triangleIndex += 3;
				
			}

			if (connectTo2 && connectTo0) {
				addTriangle (2, 0, 3, triangleIndex);
				triangleIndex += 3;
				
			}


		


	

		}





		//

		/*
		a = 0;
		b = 1;
		c = 3;

		addTriangle (a, b, c, 3);
*/


		createMesh ();
		GetComponent <CustomRender> ().CreateLinesFromMesh ();


		


	}

	void createMesh ()
	{

		Mesh mesh = new Mesh ();
		GetComponent<MeshFilter> ().mesh = mesh;


		mesh.vertices = newVertices;
//			mesh.uv = newUV;
		mesh.triangles = newTriangles;
//		mesh.RecalculateNormals();



	}


	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
