using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class Point
{

	Dictionary <float,int> fovDictionary;
	List<float> fovList;

	bool inConvexMesh;
	int visibleMostForward;
	int visibleMostBackward;


	public int index;
	private Point[] connectedPoints;
	private float fov;
//	private int observer;
	static int match;
	private int[] triangleReference;
	private Vector3[] verticeReference;
	private float PI = Mathf.PI ;
	private int maxVerts;

	public Point (int _index, int[] _triangleReference, Vector3[] _verticeReference, int _maxVerts)
	{
		index = _index;
		triangleReference = _triangleReference;
		verticeReference = _verticeReference;
		maxVerts = _maxVerts;


		pointSweep ();
	

	}

	public bool isOnEdge ()
	{

		return true;
	}

//	public void addObserver (int index){
//		observer = index;
//
//	}

	public int getClosestPoint ()
	{
		float minDistance = 100000000.0f;
		int closestPoint = -1;
		
		for (int i=0; i<maxVerts; i++) {
			
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

	public int getVisibleAntiClockwise ()
	{
		float maxAngle = -1000.0f;
		int maxIndex = -1;

		Vector2 pn = new Vector2 (verticeReference [index].x, verticeReference [index].z);
		
		// Go through all points
		for (int i=0; i<maxVerts; i++) {
			
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

	public int getVisibleClockwise ()
	{
		float minAngle = 1000.0f;
		int minIndex = -1;
		
		Vector2 pn = new Vector2 (verticeReference [index].x, verticeReference [index].z);
		
		// Go through all points
		for (int i=0; i<maxVerts; i++) {
			
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




	private void pointSweep ()
	{

		// Set up a dictionary: we use our float angle as the key, and the point that concerns as the value.
		
		fovDictionary = new Dictionary<float, int> ();
		
		Vector2 thisPoint = new Vector2 (verticeReference [index].x, verticeReference [index].z);
		
		// Loop through all points
		for (int i=0; i<maxVerts; i++) {
			// Except the intended point itself
			if (i != index) {
				Vector2 thePoint = new Vector2 (verticeReference [i].x, verticeReference [i].z);
				Vector2 cast = thePoint - thisPoint;
				float angle = Mathf.Atan2 (cast.y, cast.x);
				
				fovDictionary.Add (angle, i);
			}
			
		}
		
		// Acquire keys (the angles) and sort them
		fovList = fovDictionary.Keys.ToList ();
		fovList.Sort ();
		
		//		Debug.Log ("Lowest " + fovList [0]);
		
		// Add a key for the lowest angle plus 2PI
		fovList.Add (fovList [0] + 2 * PI);
		// Add a dictionary entry for that key, referencing the same point
		fovDictionary.Add (fovList [0] + 2 * PI, fovDictionary [fovList [0]]);

		/*
		foreach (var key in fovList) {
			Debug.Log (" " + key + " " + fovDictionary [key]);
		}
		*/
		
		
		inConvexMesh = true;
		// Loop through keys and see if there's a delta angle bigger than PI. Note that this can't happen twice. If so, this point is outside the mesh (or on the edge)
		
		for (int i=0; i<fovList.Count-1; i++) {
			if (fovList [i + 1] - fovList [i] > PI) {
				inConvexMesh = false;
				// The visble most forward point will be the one referenced by i+1.
				visibleMostForward = fovDictionary [fovList [i + 1]];
				visibleMostBackward = fovDictionary [fovList [i]];

				
				
			}
			
		}
		
//		Debug.Log ("Point is in convex mesh: " + inConvexMesh);



	}



	public bool isInConvexMesh ()
	{
		return (inConvexMesh);

	}

	public int getVisibleMostForward (){
		return visibleMostForward;
	}

	public int getVisibleMostBackward (){
		return visibleMostBackward;
	}


	/*
	static bool testMatch (int input)
	{
		
		if (input == match) {
			
			return true;
		} else {
			return false;
		}
		
	}
	*/

	public float distanceTo (int passedIndex)
	{
	
		float distance = (new Vector2 (verticeReference [passedIndex].x, verticeReference [passedIndex].z) - new Vector2 (verticeReference [index].x, verticeReference [index].z)).magnitude;


		return distance;


	}


}
