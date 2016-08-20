using UnityEngine;
using System.Collections;

public class PlayerBounce : MonoBehaviour 
{
	public float WallBounceIntensity = 30;
	public float PlayerBounceIntensity = 20;
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
			Vector3 directionOfBounce = transform.position - new Vector3(collision.transform.position.x, 0, collision.transform.position.z);

			m_playerScript.Bounce (PlayerBounceIntensity * directionOfBounce.normalized);
		}
		else
		if (collision.gameObject.tag == "Wall") 
		{
			Vector3 directionOfBounce = collision.contacts[0].normal;

			m_playerScript.Bounce (WallBounceIntensity * directionOfBounce.normalized);
		}
	}
}