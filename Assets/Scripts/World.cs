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


//	private CustomRender customRender;

	void addTriangle (int a, int b, int c, int i)
	{

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

	/*
	float pointFov (int n, int nMax){

		float minAngle = 1000.0f;
		float maxAngle = -1000.0f;
		
		Vector2 pn = new Vector2 (newVertices [n].x, newVertices [n].z);
				
		// Go through all points
		for (int i=0; i<nMax; i++) {

			// Except the intended point itself
			if (i!=n){

			Vector2 pi = new Vector2 (newVertices [i].x, newVertices [i].z);
			Vector2 cast = pi-pn;
			
			float angle = Mathf.Rad2Deg * Mathf.Atan2( cast.y,  cast.x);

			minAngle = Mathf.Min (minAngle,angle);
			maxAngle = Mathf.Max (maxAngle,angle);
			
			}
			
		}
		
//		Debug.Log ("Max: " + maxAngle + " Min: " + minAngle +" FOV: " + (maxAngle-minAngle));

		return (maxAngle - minAngle);

	}


*/
	// Use this for initialization
	void Start ()
	{

		gameObject.AddComponent<MeshFilter> ();
		gameObject.AddComponent<MeshRenderer> ();
		gameObject.AddComponent<CustomRender> ();


		int numberOfVertices = 4;


		newVertices = new Vector3[numberOfVertices];
		// first 3 verices = 1 triangle. Each next vertice can generate no more than 2 additional triangles.

		newTriangles = new int[3*(1+((numberOfVertices-3)*2)) ];




		for (int i=0; i<numberOfVertices; i++) {
			float x = -200.0f+Random.value * 400.0f;
			float y = 0.0f;
			float z = -200.0f+Random.value * 400.0f;
//			Debug.Log (x +" "+z);
			newVertices [i] = new Vector3 (x, y, z);


		}


		newVertices [0] = new Vector3 (0.0f, 0.0f, 0.0f);
		newVertices [1] = new Vector3 (100.0f, 0.0f, 0.0f);
		newVertices [2] = new Vector3 (0.0f, 0.0f, 100.0f);

//	newVertices [3] = new Vector3 (200.0f, 0.0f, 200.0f);


		// Set up the initial triangle for delauney
	
		addTriangle (0, 1, 2, 0);

	

		// Now add points one by one

		int n = 3;

		int triangleIndex = 3;


		Point newPoint =  new Point (n, newTriangles, newVertices);


//		Debug.Log ("fov: "+newPoint.getFov(n));


		if (newPoint.getFov(n) >= 180.0f) {

			Debug.Log ("Point " + n + "is in the mesh");


		} else {
			// not in mesh

			// find closest point

//			int closestPoint = newPoint.getClosestPoint(n);

			// Let start adding triangle from here

			// Create a list of points this point is connected to and iterate over those until we're done


	




//			int start = newPoint.getVisibleAntiClockwise(n);
//			int end = 

			int startIndex = newPoint.getVisibleAntiClockwise(n);

			Debug.Log("Start extreme visible anti clockwise: "+newPoint.getVisibleAntiClockwise(n));


			int endIndex = newPoint.getVisibleClockwise(n);

			Debug.Log("End extreme visible clockwise: "+endIndex);


			Point startPoint =  new Point (startIndex,newTriangles,newVertices);

			
			int[] theEdges = startPoint.findEdges(n,triangleIndex);
			
			Debug.Log ("Edge a: "+ theEdges[0]);
			Debug.Log ("Edge b: "+ theEdges[1]);
			int current, last;


			if (newPoint.distanceTo(theEdges[0]) < newPoint.distanceTo(theEdges[1]) ){

				addTriangle (startIndex, theEdges[0], n, triangleIndex);
				current =theEdges[0];
				last = startIndex;


			} else {

				addTriangle (startIndex, theEdges[1], n, triangleIndex);
				current =theEdges[1];
				last = startIndex;
			}

			triangleIndex +=3;

			/*

			Point currentPoint = new Point (current,newTriangles,newVertices);

			theEdges = currentPoint.findEdges(n,3);


			if (theEdges[0] != last && theEdges [0] != endIndex ){
				
				addTriangle (current, theEdges[0], n, triangleIndex);
				last = current;
				current =theEdges[0];
				
			} else if (theEdges [1] != endIndex ){
				
				addTriangle (current, theEdges[1], n, triangleIndex);
				last = current;
				current =theEdges[1];
			}


			
			*/
			
			


		}






//		if (pointFov (0,n) <= 180.0f) {
//			
//			Debug.Log ("Point 0 is on the edge");
//
//
//
//			
//		}






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
