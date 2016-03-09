using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour
{
	public GameObject debugObject;
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


//			debugObject.GetComponent <VisualDebug>().addDebugPoint (newVertices[n], new Color (1.0f,1.0f,1.0f));


			// Create point for our new vertice
			Point newPoint = new Point (n, newTriangles, newVertices, n);


			// Check if the point is in the mesh. If it's field of view is smaller than 180°, it is outside. If it is larger than 180°, it is inside.
			// Next, we could reject a point if it's fov is too close to 180, which'd mean it was very close to the edge.



			if (newPoint.isInConvexMesh ()) {
				// Point is in the existing mesh.

				// We'll need to find the triangle it is in, delete that and split it into 3 new ones.
				Debug.Log ("Point " + n + "is in the mesh");

//				debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [n], new Color (1.0f, 1.0f, 1.0f), 1.0f);

				for (int ti=0; ti<triangleIndex; ti += 3) {

					int ti0 = newTriangles [ti + 0];
					int ti1 = newTriangles [ti + 1];
					int ti2 = newTriangles [ti + 2];

					Triangle testTriangle = new Triangle (ti0, ti1, ti2, newVertices);

					if (testTriangle.pointWithinBounds (n)) {
						Debug.Log ("Point is in this triangle: " + ti / 3);
//						debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [ti0], new Color (1.0f, 1.0f, 1.0f), 3.0f);
//						debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [ti1], new Color (1.0f, 1.0f, 1.0f), 2.0f);
//						debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [ti2], new Color (1.0f, 1.0f, 1.0f), 1.0f);


						// We found the triangle our point is in. Now we need to delete that triangle and create 3 new ones.

						addTriangle (ti0, ti1, n, ti); // replace the triangle the new point is in

						addTriangle (ti1, ti2, n, triangleIndex); // add a triangle
						triangleIndex += 3;

						addTriangle (ti2, ti0, n, triangleIndex); // add another triangle
						triangleIndex += 3;

						break; // we found our triangle and can break the loop
					} else {
						Debug.Log ("Point is not in this triangle: " + ti / 3);
					}
				}
			} else {
				// Point is not in existing mesh. Which means we'll add triangles to connect it to all the vertices it can 'see'.
		
				int current, next, end;

				// Find out what 'visible' point is most anticlockwise, we'll start there.
				current = newPoint.getVisibleMostBackward ();

				Debug.Log ("Start extreme back: " + current);

				// Find out what 'visible' point is most clockwise, we'll stop there.
				end = newPoint.getVisibleMostForward ();

				Debug.Log ("End extreme forward: " + end);

				// Create our departure point. This point is on the edge by definition, since it is the outer one 'visible' to our new point.

				while (current != end) {
					Point currentPoint = new Point (current, newTriangles, newVertices, n);
					next = currentPoint.getVisibleMostForward ();
					Debug.Log ("next: " + next);

					addTriangle (current, next, n, triangleIndex);
					triangleIndex += 3;
					current = next;
				}

			}
			n++;
		}

		createMesh ();
		GetComponent <CustomRender> ().CreateLinesFromMesh ();

	}

	void createMesh ()
	{

		Mesh mesh = new Mesh ();
		GetComponent<MeshFilter> ().mesh = mesh;


		mesh.vertices = newVertices;

		mesh.triangles = newTriangles;


	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}
