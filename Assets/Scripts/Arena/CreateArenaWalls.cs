using UnityEngine;
using System.Collections;

public class CreateArenaWalls : MonoBehaviour {

	public int NumWalls = 12;
	public float RotationAngle = 20;
	public float WallLength = 1;

	public Transform WallPFB;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < NumWalls; i++) {
			Transform wall = Instantiate (WallPFB) as Transform;
			wall.rotation = Quaternion.Euler (0, i * RotationAngle, 0);
			wall.SetParent (transform, false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
