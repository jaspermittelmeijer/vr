using UnityEngine;
using System.Collections;

public class Triangle
{

	// class to hold a more intelligent triangle

	int[] ind;
	Vector3[] verticeReference;
	int[] triangleReference;
	Vector2 pa, pb, pc, pd;
	int[] connectedTriangles;

	public Triangle (int _indA, int _indB, int _indC, Vector3[] _verticeReference, int[] _triangleReference)
	{
		ind = new int[3];

		ind [0] = _indA;
		ind [1] = _indB;
		ind [2] = _indC;

		verticeReference = _verticeReference;
		triangleReference = _triangleReference;

//		connectedTriangles = new int[3];

//		updateConnectedTriangles ();


	}

	public int[] getConnectedTriangles ()
	{

		// Max 3. We look for the same points. If any set of 3 has 2 in common they share that edge.
		int[] connectedTriangles = new int[3];
		connectedTriangles [0] = -1;
		connectedTriangles [1] = -1;
		connectedTriangles [2] = -1;

	
		int i = 0;
		int t = 0;
		while (i< triangleReference.Length ) {
		
			int common = 0;
			for (int i2=0; i2<3; i2++) {

				for (int j=0; j<3; j++) {
					if (triangleReference [i + i2] == ind [j]){
//						Debug.Log ("Point in common: "+ ind[j]);
						common++;
					}
				}
			}
			if (common == 2) // if 3 points in common it's this triangle
			{
				Debug.Log ("Connected to triangle " + i / 3);
				connectedTriangles[t]=i/3;
				t++;
			}
			i += 3;
		}

		return (connectedTriangles);
	}

	public bool pointWithinBounds (int _pointIndex)
	{
		pd = new Vector2 (verticeReference [_pointIndex].x, verticeReference [_pointIndex].z);
		pa = new Vector2 (verticeReference [ind [0]].x, verticeReference [ind [0]].z);
		pb = new Vector2 (verticeReference [ind [1]].x, verticeReference [ind [1]].z);
		pc = new Vector2 (verticeReference [ind [2]].x, verticeReference [ind [2]].z);


//		Vector2 vec1 = pb - pa;
//		Vector2 vec2 = pd - pa;

		// A point is within this triangle if, while iterating anti-clockwise, it is always clockwise, or vice versa

		// NOTE: current code may fail if normal up or down

		bool bool01 = vectorsClockwise (pb - pa, pd - pa);
		bool bool02 = vectorsClockwise (pc - pb, pd - pb);
		bool bool03 = vectorsClockwise (pa - pc, pd - pc);

		Debug.Log (bool01 + " " + bool02 + " " + bool03);

// Check if ac is clockwise from ab or not

		if (vectorsClockwise (pb - pa, pc - pa)) {
			if (bool01 && bool02 && bool03) 
				return true;
			else
				return false;


		} else {

		
			if (bool01 && bool02 && bool03) 
				return false;
			else
				return true;


		}


		/*
		                  Vector2 thePoint = new Vector2 (verticeReference [i].x, verticeReference [i].z);
		                  Vector2 cast = thePoint - thisPoint;
		                  float angle = Mathf.Atan2 (cast.y, cast.x);
		                  */


//		return false;

	}

	bool vectorsClockwise (Vector2 vec1, Vector2 vec2)
	{

		float angle1 = Mathf.Atan2 (vec1.y, vec1.x); // -pi < atan2 <= pi
		float angle2 = Mathf.Atan2 (vec2.y, vec2.x); // 

		float angleDelta = angle1 - angle2; // E -2PI < ad <= 2PI
		// if <0 we add 2PI to simplify things
		if (angleDelta < 0.0f)
			angleDelta += 2.0f * Mathf.PI;
//		Debug.Log (angleDelta);

	
		// 0..pi:clockwise, pi..2pi: anticlock
		if (0.0f < angleDelta && angleDelta <= Mathf.PI) {
			return true;
		} else {
			return false;

		}

	}






}
