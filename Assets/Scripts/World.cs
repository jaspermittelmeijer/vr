using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

public class World : MonoBehaviour
{
	VisualDebug visualDebug;
//	GameObject delauneyObject01, terrainObject01;
//	Delauney delauney01;

	GameObject theCamera;

	Island currentIsland;
	ArrayList theIslands;

	Settings settings;

	Material mat;



	void Start ()
	{
		settings = GameObject.Find ("Root").GetComponent <Settings> (); // get a reference to the settings
		visualDebug = new VisualDebug (GameObject.Find ("Root")); // create a general purpose visual debugging object, which will have a target gameobject at root level.
		theCamera = GameObject.Find ("MainCamera");// get a reference tot he main cam


		theIslands = new ArrayList ();
		currentIsland = spawnIsland (settings.initialVerticeCount, settings.initialAmplitude, settings.initialRoughness);
		theIslands.Add (currentIsland);

		spawnCamera ();

		mat = Resources.Load ("Colour01") as Material;
		GameObject.Find ("Cube").GetComponent<Renderer> ().material = mat;

	}

	public VisualDebug getVisualDebug ()
	{
		return visualDebug;
	}

	void spawnCamera ()
	{
		// drop the camera at a random point

		Vector3 cameraPosition = new Vector3 (Random.Range (0.0f, 10.0f), 0.0f, Random.Range (0.0f, 10.0f));
		cameraPosition.y = currentIsland.getHeight (cameraPosition.x, cameraPosition.z) + 1f;
		theCamera.transform.position = cameraPosition;
		theCamera.transform.localRotation = Quaternion.LookRotation (new Vector3 (5f, 0f, 5f) - theCamera.transform.position, Vector3.up);
	}

	public void reSpawnCurrentIsland (int verticeCount, float amplitude, float roughness)
	{
		// (currently not directly in use)
		Destroy (currentIsland.getGameObject (), 0f);
		currentIsland = spawnIsland (verticeCount, amplitude, roughness);
		spawnCamera ();
	}

	public void addNewIsland (int verticeCount, float amplitude, float roughness)
	{
		// Add a new island to the buffer, switch the view, drop cam
		currentIsland.setVisible (false);
		currentIsland = spawnIsland (verticeCount, amplitude, roughness);
		theIslands.Add (currentIsland);
		spawnCamera ();
	}

	public void switchToIsland (int index)
	{
		// Switch to a buffered island, drop cam
		if (index < theIslands.Count) {
			currentIsland.setVisible (false);
			currentIsland = (Island)theIslands [index];
			currentIsland.setVisible (true);
			spawnCamera ();
		}

	}

	public int getNumberOfIslands ()
	{
		return theIslands.Count;
	}

	public int getCurrentBuffer ()
	{
		return theIslands.IndexOf (currentIsland);
	}
	public Island getCurrentIsland(){
		return currentIsland;
	}

	public int getCurrentBufferSize ()
	{
		return theIslands.Count;
	}

	public void deleteCurrentBuffer ()
	{
		// Delete the current island from the buffer and switch to 0
		Destroy (currentIsland.getGameObject (), 0f);
		theIslands.Remove (currentIsland);
		switchToIsland (0);

	}

	public Island spawnIsland (int verticeCount, float amplitude, float roughness)
	{
		// Spawn a new island and return a reference
		Island theIsland = new Island (GameObject.Find ("Root"), "Island 01");
		theIsland.spawnTerrain (10.0f, 4, amplitude, roughness);
		theIsland.spawnDelauney (verticeCount, 10f);
		return theIsland;

	}




	// Update is called once per frame
	void Update ()
	{








		/*
		Mesh mesh = new Mesh ();
		delauneyObject01.GetComponent<MeshFilter> ().mesh = mesh;
		
		mesh.vertices = delauney01.getVertices();
		mesh.triangles = delauney01.getTriangles();
		mesh.RecalculateNormals();
		delauneyObject01.GetComponent <CustomRender> ().CreateLinesFromMesh ();
	*/
	}


}
