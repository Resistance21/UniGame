using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class FauxGravityBody2 : MonoBehaviour
{
	/*
	 * Class members
	 */
	public FauxGravityAttractor2 m_Attractor2 = null;
	private int m_Grounded2 = 0;
	
	
	/*
	 * Public grounded member accessor
	 */
	public int Grounded2
	{
		get
		{
			// Return value of grounded member
			return this.m_Grounded2;
		}
	}
	
	
	/*
	 * Private start class method
	 */
	private void Awake()
	{
		// Set needed rigid body values
		this.rigidbody.WakeUp();
		this.rigidbody.useGravity = false;
		this.rigidbody.freezeRotation = true;
	}
	
	
	/*
	 * Private on collision enter class method
	 */
	private void OnCollisionEnter(Collision c)
	{
		// Check the tag of collided object
		if(c.gameObject.tag == "WorldObject")
		{
			// Increase grounded member
			this.m_Grounded2++;
		}
	}
	
	
	/*
	 * Private on collision exit class method
	 */
	private void OnCollisionExit(Collision c)
	{
		// Check the tag of collided object and grounded member value
		if(c.gameObject.tag == "WorldObject" && this.m_Grounded2 > 0)
		{
			// Decrease grounded member
			this.m_Grounded2--;
		}
	}
	
	
	/*
	 * Private fixed update class method
	 */
	private void FixedUpdate()
	{
		// Check if attractor member is set
		if(this.m_Attractor2 != null)
		{
			// Apply attract to object
			this.m_Attractor2.Attract(this);
		}
	}
}
