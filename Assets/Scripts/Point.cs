using UnityEngine;
using System.Collections;
using System;

public class Point
{

	public int index;
	private Point[] connectedPoints;
	private float fov;
//	private int observer;
	static int match;
	private int[] triangleReference;
	private Vector3[] verticeReference;

	public Point (int _index, int[] _triangleReference, Vector3[] _verticeReference)
	{
		index = _index;
		triangleReference = _triangleReference;
		verticeReference = _verticeReference;


	}

	public bool isOnEdge ()
	{

		return true;
	}

//	public void addObserver (int index){
//		observer = index;
//
//	}

	public int getClosestPoint (int nMax)
	{
		float minDistance = 100000000.0f;
		int closestPoint = -1;
		
		for (int i=0; i<nMax; i++) {
			
			float distance = (new Vector2 (verticeReference [i].x, verticeReference [i].z) - new Vector2 (verticeReference [index].x, verticeReference [index].z)).magnitude;
//			Debug.Log ("Distance to " + i + "= " + distance);
			
			if (distance < minDistance) {
				closestPoint = i;
				Debug.Log ("closest point: " + closestPoint);
				
			}
			minDistance = Mathf.Min (minDistance, distance);
			
			
		}

		return closestPoint;

	}

	public int getVisibleAntiClockwise (int nMax)
	{
		float maxAngle = -1000.0f;
		int maxIndex = -1;

		Vector2 pn = new Vector2 (verticeReference [index].x, verticeReference [index].z);
		
		// Go through all points
		for (int i=0; i<nMax; i++) {
			
			// Except the intended point itself
			if (i != index) {
				
				Vector2 pi = new Vector2 (verticeReference [i].x, verticeReference [i].z);
				
				Vector2 cast = pi - pn;
				
				float angle = Mathf.Rad2Deg * Mathf.Atan2 (cast.y, cast.x);

				if (angle > maxAngle) {
					maxIndex = i;

				}

				maxAngle = Mathf.Max (maxAngle, angle);
				
			}
			
		}
		
		//		Debug.Log ("Max: " + maxAngle + " Min: " + minAngle +" FOV: " + (maxAngle-minAngle));
		
		return (maxIndex);

	}

	public int getVisibleClockwise (int nMax)
	{
		float minAngle = 1000.0f;
		int minIndex = -1;
		
		Vector2 pn = new Vector2 (verticeReference [index].x, verticeReference [index].z);
		
		// Go through all points
		for (int i=0; i<nMax; i++) {
			
			// Except the intended point itself
			if (i != index) {
				
				Vector2 pi = new Vector2 (verticeReference [i].x, verticeReference [i].z);
				
				Vector2 cast = pi - pn;
				
				float angle = Mathf.Rad2Deg * Mathf.Atan2 (cast.y, cast.x);
				
				if (angle < minAngle) {
					minIndex = i;
					
				}
				
				minAngle = Mathf.Min (minAngle, angle);
				
			}
			
		}
		
		//		Debug.Log ("Max: " + maxAngle + " Min: " + minAngle +" FOV: " + (maxAngle-minAngle));
		
		return (minIndex);
		
	}

	public float getFov (int nMax)
	{
		
		float minAngle = 1000.0f;
		float maxAngle = -1000.0f;
		
		Vector2 pn = new Vector2 (verticeReference [index].x, verticeReference [index].z);
		
		// Go through all points
		for (int i=0; i<nMax; i++) {
			
			// Except the intended point itself
			if (i != index) {
				
				Vector2 pi = new Vector2 (verticeReference [i].x, verticeReference [i].z);
				
				//			float angle = Vector2.Angle(pi-pn, zero);
				
				Vector2 cast = pi - pn;
				
				float angle = Mathf.Rad2Deg * Mathf.Atan2 (cast.y, cast.x);
				
				//			Debug.Log (cast.x +" " + cast.y+ " angle: "+angle);
				
				minAngle = Mathf.Min (minAngle, angle);
				maxAngle = Mathf.Max (maxAngle, angle);
				
			}
			
		}
		
		//		Debug.Log ("Max: " + maxAngle + " Min: " + minAngle +" FOV: " + (maxAngle-minAngle));
		
		return (maxAngle - minAngle);
		
	}

	static bool testMatch (int input)
	{
		
		if (input == match) {
			
			return true;
		} else {
			return false;
		}
		
	}

	public float distanceTo (int passedIndex) {
	
		float distance = (new Vector2 (verticeReference [passedIndex].x, verticeReference [passedIndex].z) - new Vector2 (verticeReference [index].x, verticeReference [index].z)).magnitude;


		return distance;


	}


	public int[] findEdges (int nMax, int tMax)
	{

		// we know that on the edge every point is connected to 2 other points on the edge
		match = index;

		int[] edges = new int[2];
		edges [0] = -1;
		edges [1] = -1;


		int e = 0;
	
		int j = 0;

		while (Array.FindIndex<int> (triangleReference, j, testMatch) != -1) {

			int indexOfPoint = Array.FindIndex<int> (triangleReference, j, testMatch);
			int indexOfTriangle = indexOfPoint / 3;

			if (indexOfTriangle *3 >= tMax){
				Debug.Log("Triangle out of range, aborting");
				break;
			}
		
			for (int i=0; i<3; i++) {
			
				if (i != indexOfPoint % 3) {

					int c = triangleReference [indexOfTriangle * 3 + i];

//					Debug.Log ("triangle: " + indexOfTriangle);
//					Debug.Log ("connected: " + c);

					Point connectedPoint = new Point (c, triangleReference, verticeReference);
					if (connectedPoint.getFov (nMax) < 180.0f) {
						Debug.Log ("Connected point: "+ c +" fount in triangle no: "+indexOfTriangle +" is on mesh' edge.");

						if (edges [0] != c && edges [1] !=c){
						edges[e]=c;
						e++;
						}


					}
				}
			}

			j = indexOfPoint+1;


		}

		return edges;
	}



}
