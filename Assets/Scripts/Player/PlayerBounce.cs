using UnityEngine;
using System.Collections;

public class PlayerBounce : MonoBehaviour 
{
	public float WallBounceIntensity = 2;
	public float PlayerBounceIntensity = 50;
	// Use this for initialization
	Rigidbody m_rigidBody;
	Player m_playerScript;
	void Start () 
	{
		m_rigidBody = GetComponent<Rigidbody> ();
		m_playerScript = GetComponent<Player> ();
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") 
		{
			print ("In here");

			Vector3 directionOfBounce = transform.position - new Vector3(collision.transform.position.x, 0, collision.transform.position.z);
			//print (m_rigidBody.velocity);
			m_playerScript.Bounce (PlayerBounceIntensity * directionOfBounce.normalized);
			//m_rigidBody.velocity += PlayerBounceIntensity * directionOfBounce;
			//print (m_rigidBody.velocity);

			Debug.DrawRay (transform.position, directionOfBounce * 2, Color.red, 2);
		}
	}
}