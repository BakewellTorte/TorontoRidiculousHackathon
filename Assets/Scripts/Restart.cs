using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public KeyCode RestartHotKey = KeyCode.F1;
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (RestartHotKey)) 
		{
			SceneManager.LoadScene ("Main");
		}
	}				
}
