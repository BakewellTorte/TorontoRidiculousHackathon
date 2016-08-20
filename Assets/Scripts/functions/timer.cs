using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class timer : MonoBehaviour {

	public float timeLeft = 10f;
	public Text timerText;


	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("decreaseTimeRemaining", 0.05f, 0.5f);

	}

	// Update is called once per frame
	void Update () {
		if (timeLeft == 0)
		{
		//	sendMessageUpward("timeElapsed");

		}

	//	GuiText.text = timeLeft + " Seconds remaining!";
	}
	void decreaseTimeRemaining()
	{

		if (timeLeft < 0.5f) {
			//	sendMessageUpward("timeElapsed");
			timeLeft = 0.00f;
			timerText.text = "Game Over";

		} else {

			timeLeft -= 0.54500f;
			//timerText.text = "Let the games begin "  + timeLeft.ToString ();
			timerText.text = "Start " + string.Format("{0:.##}",timeLeft);
		}
	}
}



