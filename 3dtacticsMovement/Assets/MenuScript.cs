using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuScript
{
	[MenuItem("Tools/Assaign Tile Material")]
	public static void AssignTileMaterial()
	{
		GameObject[] tiles = GameObject.FindGameObjectsWithTag("tile");
		Material material = Resources.Load<Material>("Tile");

		foreach(GameObject t in tiles)
		{
			t.GetComponent<Renderer>().material = material;
		}
	}

	[MenuItem("Tools/Assign Tile Script")]
	public static void AssignTileScript () 
	{
		GameObject[] tiles = GameObject.FindGameObjectsWithTag("tile");
	

		foreach(GameObject t in tiles)
		{
			t.AddComponent<Tile>();
		}
	}
}
