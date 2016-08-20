using UnityEngine;
using System.Collections;

public class PlayerAppearance : MonoBehaviour {

	public GameObject[] Images;

	// Use this for initialization
	void Start () {
		int image = Random.Range (0, Images.Length - 1);
		Images [image].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
