using System;
using UnityEngine;
using System.Linq;

public class Island
{
	// Class to hold a complete island
	RandomTerrain iTerrain;
	Delauney iDelauney;
	Material iMaterial01;
	GameObject iSelf, iDelauneyObject, iTerrainObject;
	Color iLineColor;
	Mesh workingMesh;
	VisualDebug iVisualDebug;


	public Island (GameObject _parentObject, String _myName)
	{
		// basic initialisation
		initialiseIsland (_parentObject, _myName);
		setDefaultMaterials ();
	}




	private void initialiseIsland (GameObject _parent, String _name)
	{
		iSelf = new GameObject (_name);
		iSelf.transform.parent = _parent.transform;
		iVisualDebug = new VisualDebug (iSelf);
	}

	private void setDefaultMaterials ()
	{
		setMaterial (Resources.Load ("Default") as Material);
		iLineColor = Color.black; // setting a default linecolor

	}


	public void setVisible (bool visible){
//		iSelf.transform.enable
		iSelf.SetActive(visible);
	}




	public void setMaterial (Material _mat)
	{
		iMaterial01 = _mat;
	}

	public void setLineColor (Color _color)
	{
		iLineColor = _color;
	}


	public void spawnTerrain (float _size, int _iterations, float _amp, float _roughness)
	{

		iTerrain = new RandomTerrain (_size, _iterations, _amp, _roughness);
		iTerrain.setVisualDebug (iVisualDebug);
		iTerrain.spawn ();


		iTerrainObject = new GameObject ("iTerrain");
		iTerrainObject.transform.parent = iSelf.transform;
		iTerrainObject.AddComponent<MeshFilter> ();
		iTerrainObject.AddComponent<MeshRenderer> ();
		iTerrainObject.AddComponent<CustomRender> ();

		workingMesh = new Mesh ();
		iTerrainObject.GetComponent<MeshFilter> ().mesh = workingMesh;

		workingMesh.vertices = iTerrain.getVertices ();
		workingMesh.triangles = iTerrain.getTriangles ();
		workingMesh.RecalculateNormals ();
		iTerrainObject.GetComponent <CustomRender> ().CreateLinesFromMesh ();

		iTerrainObject.GetComponent<Renderer> ().material = iMaterial01;
		iTerrainObject.GetComponent<CustomRender> ().passColor (iLineColor);
		iTerrainObject.SetActive (true);

	}

	public void spawnDelauney (int vertices, float size)
	{
		iDelauney = new Delauney ();
		iDelauney.createDelauney (vertices, size, iTerrain);


		iDelauneyObject = new GameObject ("iDelauney");
		iDelauneyObject.transform.parent = iSelf.transform;

		iDelauneyObject.AddComponent<MeshFilter> ();
		iDelauneyObject.AddComponent<MeshRenderer> ();
		iDelauneyObject.AddComponent<CustomRender> ();

		workingMesh = new Mesh ();
		iDelauneyObject.GetComponent<MeshFilter> ().mesh = workingMesh;

		workingMesh.vertices = iDelauney.getVertices ();
		workingMesh.triangles = iDelauney.getTriangles ();
		workingMesh.RecalculateNormals ();

		iDelauneyObject.GetComponent<CustomRender> ().passColor(iLineColor);

		iDelauneyObject.GetComponent <CustomRender> ().CreateLinesFromMesh ();
		iDelauneyObject.GetComponent<Renderer> ().material = iMaterial01;

		spawnBackfaceObject ();

	}

	private void spawnBackfaceObject (){
		GameObject workingObject = new GameObject ("iDelauney Backfaces");
		workingObject.transform.parent = iSelf.transform;

		workingObject.AddComponent<MeshFilter> ();
		workingObject.AddComponent<MeshRenderer> ();


		workingMesh = new Mesh ();
		workingObject.GetComponent<MeshFilter> ().mesh = workingMesh;

		workingMesh.vertices = iDelauney.getVertices ();
		workingMesh.triangles = iDelauney.getTriangles ();
		//		mesh.triangles = mesh.triangles.Reverse ();
		workingMesh.RecalculateNormals ();

		workingMesh.triangles = workingMesh.triangles.Reverse ().ToArray ();

		workingObject.GetComponent<Renderer>().material = iMaterial01;
		workingObject.GetComponent<Renderer> ().receiveShadows = false;


	}

	public float getHeight(float i,float j){

		return (iTerrain.getHeight (i, j));
	}
	public GameObject getGameObject (){
		return (iSelf);
	}
	public Delauney getDelauney(){
		return (iDelauney);
	}



}


