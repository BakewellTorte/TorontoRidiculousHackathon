using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float Size = 1;
	public float MovementSpeedMultiplier = 1;

	public string HorizontalAxis = "Horizontal";
	public string VerticalAxis = "Vertical";

	// Use this for initialization
	private Rigidbody m_rigidBody;
	void Start () 
	{
		transform.localScale = new Vector3 (Size, Size, Size);	

		m_rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	private float m_prevSize;
	void FixedUpdate () 
	{
		float horizontalInput = Input.GetAxis (HorizontalAxis);
		float verticalInput = Input.GetAxis (VerticalAxis);

		if (m_prevSize != Size) 
		{
			transform.localScale = new Vector3 (Size, Size, Size);	
			m_prevSize = Size;
		}

		//print (horizontalInput);
		m_rigidBody.velocity = new Vector3 (MovementSpeedMultiplier * horizontalInput, 0, MovementSpeedMultiplier * verticalInput);
	}

	void OnTriggerEnter(Collider other)
	{
		
	}
}
