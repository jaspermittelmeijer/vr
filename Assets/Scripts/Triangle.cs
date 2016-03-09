using UnityEngine;
using System.Collections;

public class Triangle
{

	// class to hold a more intelligent triangle

	int indA, indB, indC;
	Vector3[] verticeReference;
	Vector2 pa,pb,pc,pd;

	public Triangle (int _indA, int _indB, int _indC, Vector3[] _verticeReference)
	{
		indA = _indA;
		indB = _indB;
		indC = _indC;

		verticeReference = _verticeReference;



	}

	public bool pointWithinBounds (int _pointIndex)
	{
		pd = new Vector2 (verticeReference [_pointIndex].x, verticeReference [_pointIndex].z);
		pa = new Vector2 (verticeReference [indA].x, verticeReference [indA].z);
		pb = new Vector2 (verticeReference [indB].x, verticeReference [indB].z);
		pc = new Vector2 (verticeReference [indC].x, verticeReference [indC].z);


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

	public bool vectorsClockwise (Vector2 vec1, Vector2 vec2){

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
