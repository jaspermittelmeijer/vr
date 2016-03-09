using UnityEngine;
using System.Collections;
//using  System.Threading;

public class Delauney
{

	// A class to hold/create a delauney triangulation
	Vector3[] verticeData;
	Vector2[] edgeData;
	int[] triangleData;
	Triangle[] triangles;
	Point[] points;

	public Delauney ()
	{


	}

	public IEnumerator createDelauney (int numberOfVertices, float dimensions)
	{


//		int numberOfVertices = 10;
		
		
		verticeData = new Vector3[numberOfVertices];
		
		// first 3 verices = 1 triangle. Each next vertice can generate no more than 2 additional triangles. This may be untrue
		triangleData = new int[3 * numberOfVertices * 2 ];


		
		float x, y, z;
		
		for (int i=0; i<3; i++) {
			x = -0.5f * dimensions + Random.value * dimensions;
			y = 0.0f;
			z = -0.5f * dimensions + Random.value * dimensions;
			//			Debug.Log (x +" "+z);
			verticeData [i] = new Vector3 (x, y, z);
			
			
		}
		
//		
//		verticeData [0] = new Vector3 (0.0f, 0.0f, 0.0f);
//		verticeData [1] = new Vector3 (100.0f, 0.0f, 0.0f);
//		verticeData [2] = new Vector3 (0.0f, 0.0f, 100.0f);
		
		
		
		// Set up the initial triangle for delauney
		addTriangle (0, 1, 2, 0);
		
		// Now start adding points, and add triangles as we go
		
		int n = 3;
		int triangleIndex = 3;
		
		
		while (n<numberOfVertices) {

			yield return new WaitForSeconds(0.1f);



//			Thread.Sleep(1000);

//			yield return new WaitForSeconds(5);

			
			// Create a vertice
			x = -0.5f * dimensions + Random.value * dimensions;
			y = 0.0f;
			z = -0.5f * dimensions + Random.value * dimensions;
			verticeData [n] = new Vector3 (x, y, z);
			
			
			//			debugObject.GetComponent <VisualDebug>().addDebugPoint (newVertices[n], new Color (1.0f,1.0f,1.0f));
			
			
			// Create point for our new vertice
			Point newPoint = new Point (n, triangleData, verticeData, n);
			
			
			// Check if the point is in the mesh. If it's field of view is smaller than 180°, it is outside. If it is larger than 180°, it is inside.
			// Next, we could reject a point if it's fov is too close to 180, which'd mean it was very close to the edge.
			
			
			
			if (newPoint.isInConvexMesh ()) {
				// Point is in the existing mesh.
				
				// We'll need to find the triangle it is in, delete that and split it into 3 new ones.
				Debug.Log ("Point " + n + "is in the mesh");
				
				//				debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [n], new Color (1.0f, 1.0f, 1.0f), 1.0f);
				
				for (int ti=0; ti<triangleIndex; ti += 3) {
					
					int ti0 = triangleData [ti + 0];
					int ti1 = triangleData [ti + 1];
					int ti2 = triangleData [ti + 2];
					
					Triangle testTriangle = new Triangle (ti0, ti1, ti2, verticeData);
					
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
					Point currentPoint = new Point (current, triangleData, verticeData, n);
					next = currentPoint.getVisibleMostForward ();
					Debug.Log ("next: " + next);
					
					addTriangle (current, next, n, triangleIndex);
					triangleIndex += 3;
					current = next;
				}
				
			}
			n++;
		}


	}

	public	Vector3[]  getVertices ()
	{
		return verticeData;
	}

	public int[] getTriangles ()
	{
		return triangleData;

	}

	void addTriangle (int a, int b, int c, int i)
	{
		Vector3 leg1, leg2, normal;
		
		Debug.Log ("Added triangle: " + a + " " + b + " " + c + " at: " + i);
				
		leg1 = verticeData [b] - verticeData [a];
		leg2 = verticeData [c] - verticeData [a];
		normal = Vector3.Cross (leg1, leg2);
		
		if (normal.y >= 0.0f) {
			//			Debug.Log ("Normal pointing up");
			triangleData [i + 0] = a;
			triangleData [i + 1] = b;
			triangleData [i + 2] = c;
//			Triangle [i / 3] = new Triangle (a, b, c, verticeData);


		} else {
			
			//			Debug.Log ("Normal down, swapping points");
			triangleData [i + 0] = a;
			triangleData [i + 1] = c;
			triangleData [i + 2] = b;
//			Triangle [i / 3] = new Triangle (a, c, b, verticeData);

		}
		
		
	}
}
