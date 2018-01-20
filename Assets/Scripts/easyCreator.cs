using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class tiles
//{
//
//	public GameObject gameObject;
//	public Material tileMat;
//
//
//}


public class easyCreator : MonoBehaviour
{

	public GameObject tilePrefab;
	public int columns;
	public int rows;
	public float padding = 0.5f;
//	public Material[] materialList = new Material[2];
//	int matIndex = 0;
	public Color tile1;
	public Color tile2;
	public GameObject[] tilesAll;
	public GameObject[] tilesMined;
	public GameObject[] tilesUnMined;


	// Use this for initialization
	void Start ()
	{
		CreateTiles ();	
	}
	// Update is called once per frame
	void Update ()
	{
		
	}

	void CreateTiles() {
		for (int z = 0; z < columns; z = z + 1) {
			//matIndex = z % 2;
			for (int x = 0; x < rows; x = x + 1) {
				GameObject _clone = Instantiate (tilePrefab, new Vector3 (x, 0, z), Quaternion.identity) as GameObject;
				//				Material _mat = _clone.GetComponent<Material> ();

				//				_mat.color

				if (x % 2 == 0) {
					if (z % 2 == 0) {
						_clone.GetComponent<Renderer> ().material.color = tile1;
						//Debug.Log("Tile Colors1");
					} else {
						_clone.GetComponent<Renderer> ().material.color = tile2;
						//Debug.Log("Tile Colors2");
					}
				} else {
					if (z % 2 == 0) {
						_clone.GetComponent<Renderer> ().material.color = tile2;
						//Debug.Log("Tile Colors3");
					} else {
						_clone.GetComponent<Renderer> ().material.color = tile1;
						//	Debug.Log("Tile Colors4");
					}
				}

			}
		}
	}
}

