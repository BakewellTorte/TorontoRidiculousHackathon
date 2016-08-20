using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float Size = 1;
	public float MovementSpeedMultiplier = 1;

	public float TimeBounce = 0.25f;

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
	private Vector3 m_smoothDampVelocity;
	void FixedUpdate () 
	{
		float horizontalInput = Input.GetAxis (HorizontalAxis);
		float verticalInput = Input.GetAxis (VerticalAxis);

		if (m_prevSize != Size) 
		{
			transform.localScale = new Vector3 (Size, Size, Size);	
			m_prevSize = Size;
		}


		if(m_bounce.magnitude != 0)
			m_bounce = Vector3.SmoothDamp (m_bounce, Vector3.zero, ref m_smoothDampVelocity, TimeBounce);

		m_rigidBody.velocity = new Vector3 (MovementSpeedMultiplier * horizontalInput, 0, MovementSpeedMultiplier * verticalInput)
			+ m_bounce;	

	}
		
	private Vector3 m_bounce;
	public void Bounce(Vector3 direction)
	{
		m_bounce = direction;
		//m_rigidBody.velocity += direction;
	}
}
