﻿using UnityEngine;
using System.Collections;

//using  System.Threading;

public class Delauney
{

	// A class to hold/create a delauney triangulation
	Vector3[] verticeData;
//	Vector2[] edgeData;
	int[] triangleData;
	Triangle[] triangles;
	private Triangle triangleMethods;

	Point[] points;
	int triangleIndex;
	ArrayList  flipStack;


	public Delauney ()
	{


	}

	public void createDelauney (int numberOfVertices, float dimensions, RandomTerrain terrainWrapper)
	{


//		int numberOfVertices = 10;
		triangleMethods = new Triangle ();


		
		verticeData = new Vector3[numberOfVertices + 1];
		
		// first 3 verices = 1 triangle. Each next vertice can generate no more than 2 additional triangles. This may be untrue
		triangleData = new int[3 * numberOfVertices * 2 ];

		// Populate the array with -1's
		for (int i=0; i<triangleData.Length; i++)
			triangleData [i] = numberOfVertices;


		
		float x, y, z;
		
		for (int i=0; i<3; i++) {
			x =  Random.value * dimensions;
//			y = Random.value * 50.0f;
			z = Random.value * dimensions;
			//			Debug.Log (x +" "+z);
			y= terrainWrapper.getHeight(x,z);

			verticeData [i] = new Vector3 (x, y, z);
			
			
		}
		
//		
//		verticeData [0] = new Vector3 (0.0f, 0.0f, 0.0f);
//		verticeData [1] = new Vector3 (100.0f, 0.0f, 0.0f);
//		verticeData [2] = new Vector3 (0.0f, 0.0f, 100.0f);
		
		
		
		// Set up the initial triangle for delauney
		addTriangle (0, 1, 2, 0);

//		triangleMethods.getConnectedTrianglesFor (0);

		// Now start adding points, and add triangles as we go
		
		int n = 3;
		triangleIndex = 1;//3
		flipStack = new ArrayList ();

		
		while (n<numberOfVertices) {

//			yield return new WaitForSeconds (0.05f);




			// Create a vertice
			x = Random.value * dimensions;
//			y = Random.value * 50.0f;

			z = Random.value * dimensions;
			y= terrainWrapper.getHeight(x,z);


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

//				GameObject.Find ("VisualDebug").GetComponent <VisualDebug> ().addDebugPoint (verticeData [n], new Color (1.0f, 1.0f, 1.0f), 1.0f);
//				debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [n], new Color (1.0f, 1.0f, 1.0f), 1.0f);
				
				for (int ti=0; ti<triangleIndex; ti ++) {
					
					int ti0 = triangleData [ti *3  + 0];
					int ti1 = triangleData [ti *3 + 1];
					int ti2 = triangleData [ti *3 + 2];
					
					Triangle testTriangle = new Triangle (ti0, ti1, ti2, verticeData, triangleData);
//					int[] connected = testTriangle.getConnectedTriangles ();

					
					if (testTriangle.pointWithinBounds (n)) {
						Debug.Log ("Point is in this triangle: " + ti );
						//						debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [ti0], new Color (1.0f, 1.0f, 1.0f), 3.0f);
						//						debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [ti1], new Color (1.0f, 1.0f, 1.0f), 2.0f);
						//						debugObject.GetComponent <VisualDebug> ().addDebugPoint (newVertices [ti2], new Color (1.0f, 1.0f, 1.0f), 1.0f);
						
						
						// We found the triangle our point is in. Now we need to delete that triangle and create 3 new ones.
						
						addTriangle (ti0, ti1, n, ti); // replace the triangle the new point is in

						addToFlipStack( ti);

						addTriangle (ti1, ti2, n, triangleIndex); // add a triangle
						addToFlipStack(triangleIndex);
						triangleIndex ++;
						
						addTriangle (ti2, ti0, n, triangleIndex); // add another triangle
						addToFlipStack(triangleIndex);
						triangleIndex ++;
						
						break; // we found our triangle and can break the loop
					} else {
//						Debug.Log ("Point is not in this triangle: " + ti );
					}
				}
			} else {
				// Point is not in existing mesh. Which means we'll add triangles to connect it to all the vertices it can 'see'.
				
				int current, next, end;
				
				// Find out what 'visible' point is most anticlockwise, we'll start there.
				current = newPoint.getVisibleMostBackward ();
				
//				Debug.Log ("Start extreme back: " + current);
				
				// Find out what 'visible' point is most clockwise, we'll stop there.
				end = newPoint.getVisibleMostForward ();
				
//				Debug.Log ("End extreme forward: " + end);
				
				// Create our departure point. This point is on the edge by definition, since it is the outer one 'visible' to our new point.
				
				while (current != end) {
					Point currentPoint = new Point (current, triangleData, verticeData, n);
					next = currentPoint.getVisibleMostForward ();
//					Debug.Log ("next: " + next);
					
					addTriangle (current, next, n, triangleIndex);
					addToFlipStack(triangleIndex);

					triangleIndex ++;
					current = next;
				}
				
			}
			n++;

			// now  flip all traingles untill it's a perfect delauney. Note that this is very brute force. It would be better to establish which triangles have been affected and keep recursively flipping just those.
//			while (	flipAllTriangles());
//			flipAllTriangles();
			if (flipStack.Count > 0) {
				while (flipFlipStack ())
					;
			}



//			delauneyTest (0, 1);


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

	bool delauneyTest (int a, int b)
	{

		// test if touching triangles a and b are delauney: the inner angles opposite both sides of the common edge, when added, cannot be more than 180°
		// we need to the 2 vertices that do not appear in the other triangle
		int[] vertsA = new int[3];
		int[] vertsB = new int[3];

		vertsA [0] = triangleData [a * 3 + 0];
		vertsA [1] = triangleData [a * 3 + 1];
		vertsA [2] = triangleData [a * 3 + 2];

		vertsB [0] = triangleData [b * 3 + 0];
		vertsB [1] = triangleData [b * 3 + 1];
		vertsB [2] = triangleData [b * 3 + 2];

		int va, vb, vc, vd; // a and b are the uncommon vertices, c and d are the common edge

		va = -1;
		vb = -1;
		vc = -1;
		vd = -1;
		for (int i=0; i<3; i++) {
			bool isEdge = false;
			for (int j=0; j<3; j++) {
//				Debug.Log (" " + vertsA [i] + " " + vertsB [j]);
				if (vertsA [i] == vertsB [j]) {

					isEdge = true;

				}
			}
			if (!isEdge) {
				va = vertsA [i];

//				GameObject.Find ("VisualDebug").GetComponent <VisualDebug> ().addDebugPoint (verticeData [va], new Color (1.0f, 1.0f, 1.0f), 1.0f);

			}
			if (isEdge) {
				if (vc == -1)
					vc = vertsA [i];
				else
					vd = vertsA [i];

			}




		}

		for (int i=0; i<3; i++) {
			bool isEdge = false;
			for (int j=0; j<3; j++) {
//				Debug.Log (" " + vertsB [i] + " " + vertsA [j]);
				if (vertsB [i] == vertsA [j]) {

					isEdge = true;
					
				}
			}
			if (!isEdge) {
				vb = vertsB [i];

//				GameObject.Find ("VisualDebug").GetComponent <VisualDebug> ().addDebugPoint (verticeData [vb], new Color (1.0f, 1.0f, 1.0f), 1.0f);
				
			}
			
		}

		Debug.Log ("Testing triangle: " + a + " & " + b);

		Debug.Log ("a: " + va + "b: " + vb + "c: " + vc + "d: " + vd);

		Vector3 pa,pb,pc,pd;


		pa = new Vector2 (verticeData [va].x, verticeData [va].z);
		pb = new Vector2 (verticeData [vb].x, verticeData [vb].z);
		pc = new Vector2 (verticeData [vc].x, verticeData [vc].z);
		pd = new Vector2 (verticeData [vd].x, verticeData [vd].z);


		float anglea = Vector2.Angle (pc-pa, pd-pa);
//		Debug.Log ("Angle a: " + anglea);
		float angleb = Vector2.Angle (pc-pb, pd-pb);
//		Debug.Log ("Angle b: " + angleb);

		if (anglea + angleb > 180.0f) {
			Debug.Log ("************************************Triangles must be flipped");

			addTriangle (va, vb, vc, a );
			addTriangle (va, vb, vd, b );
			return true;

		} else {
		
		
			return false;
		}
	}

	public bool flipAllTriangles () {
		// Now flip any triangles that aren't delauney
		// Brute force: go over all of them.
		bool flipped = false;
		
		for (int i=0;i<triangleIndex;i++){

			/*
			Triangle checkTriangle = new Triangle (triangleData[i*3],triangleData[i*3+1],triangleData[i*3+2],verticeData,triangleData);
			int[] getConnected = checkTriangle.getConnectedTriangles();
*/
			int[] getConnected = triangleMethods.getConnectedTrianglesFor(i,triangleData);



			
			for (int j=0;j<3;j++){
				if (getConnected[j] != -1){
					if (delauneyTest(i,getConnected[j])){
						flipped = true;
						break;
					}
				}
			}
			
		}
		
		return flipped;
	}

	private void addToFlipStack (int a){
		if (flipStack.IndexOf (a) == -1) {
			flipStack.Add (a);
		}
	}


	bool flipFlipStack () {
		bool flipped = false;



		int i = (int) flipStack [0];

		int[] getConnected = triangleMethods.getConnectedTrianglesFor(i,triangleData);
		flipStack.RemoveAt (0);

		for (int j=0;j<3;j++){
			if (getConnected[j] != -1){
				// Once we have flipped triangles, it's useless to look at the other connected triangles, since our original has now changed and we don't even now if they're still connected. 
				// That does however mean we need to stack those connected triangles because they may still be off and we wouldn't touch on them otherwise.

				if (!flipped) {

					if (delauneyTest (i, getConnected [j])) {
						flipped = true;
						// flipping the triangles may affect others
						addToFlipStack (i);
						addToFlipStack (j);

					} 
				} else {
					// we have an orphaned triangle that we need to restack
					addToFlipStack (getConnected [j]);
				}
			}
		}

	





		return flipped;
	}

	
	

	void addTriangle (int a, int b, int c, int i)
	{
		Vector3 leg1, leg2, normal;
		
		Debug.Log ("Inserted triangle: " + a + " " + b + " " + c + " at: " + i +" in a total of " + triangleIndex);
				
		leg1 = verticeData [b] - verticeData [a];
		leg2 = verticeData [c] - verticeData [a];
		normal = Vector3.Cross (leg1, leg2);
		
		if (normal.y >= 0.0f) {
			//			Debug.Log ("Normal pointing up");
			triangleData [i*3 + 0] = a;
			triangleData [i*3 + 1] = b;
			triangleData [i*3 + 2] = c;
//			Triangle [i / 3] = new Triangle (a, b, c, verticeData, triangleData);


		} else {
			
			//			Debug.Log ("Normal down, swapping points");
			triangleData [i*3 + 0] = a;
			triangleData [i*3 + 1] = c;
			triangleData [i*3 + 2] = b;
			//			Triangle [i / 3] = new Triangle (a, c, b, verticeData, triangleData);

		}
		
		
	}
}
