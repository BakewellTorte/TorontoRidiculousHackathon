using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndZone : MonoBehaviour {


	public GameObject Results;

	public Text firstText;
	public Text secondText;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	bool playerEnter = false;

	private int m_numFinished;
	private string m_first, m_second;
	void OnTriggerEnter (Collider collider) {



		if (collider.gameObject.tag == "Player") {
			if (m_numFinished >= 2)
				return;

			if (collider.gameObject.transform.parent.name == m_first || collider.gameObject.transform.parent.name == m_second)
				return;

			if (m_numFinished == 0)
				m_first = collider.gameObject.transform.parent.name;
			else if (m_numFinished == 1)
				m_second = collider.gameObject.transform.parent.name;

	

			m_numFinished++;

			if (!Results.activeInHierarchy)
				Results.SetActive (true);

			print ("Player has entered trigger zone");

			//result text
			if (playerEnter == false) {//no plaer entered yet
				firstText.text = "1st (You Lost):" + m_first;
			} else if ((playerEnter == true) && (collider.gameObject.transform.parent.name != m_first)) {//second player entering
				secondText.text = "2nd (You Won):" + collider.gameObject.transform.parent.name;
			}

			playerEnter = true;

		}
	}

}