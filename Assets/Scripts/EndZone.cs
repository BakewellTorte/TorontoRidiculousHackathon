using UnityEngine;

public class EndZone : MonoBehaviour 
{

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject.tag == "Player") {
			print ("Player has entered trigger zone");
			//track player time (score)
			Debug.Log(string.Format("{0} has finished with a time of {1}", collider.gameObject.transform.parent.name, "sdf"));



	}
}
}