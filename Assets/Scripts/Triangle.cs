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

	bool pointWithinBounds (int _pointIndex)
	{
		pd = new Vector2 (verticeReference [_pointIndex].x, verticeReference [_pointIndex].z);

		// A point is within this triangle if, while iterating anti-clockwise, it is always



		/*
		                  Vector2 thePoint = new Vector2 (verticeReference [i].x, verticeReference [i].z);
		                  Vector2 cast = thePoint - thisPoint;
		                  float angle = Mathf.Atan2 (cast.y, cast.x);
		                  */


		return false;

	}

	bool vectorsClockwise (Vector2 vec1, Vector2 vec2){

		float angle1 = Mathf.Atan2 (vec1.y, vec1.x); // -pi to pi
		float angle2 = Mathf.Atan2 (vec2.y, vec2.x); // -pi to pi

		float angleDelta = angle1 - angle2; // min value -2pi, max value 2pi
		// 0..pi:clockwise, pi..2pi: anticlock, -pi..0 anticlock, -2pi..-pi clock

		if ((angleDelta >= 0.0f && angleDelta < Mathf.PI) || (angleDelta >= - 2.0f * Mathf.PI && angleDelta < -1.0f * Mathf.PI)) {


			return true;
		} else {
			return false;

		}










	}






}
