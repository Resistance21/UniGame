using UnityEngine;

public class FauxGravityAttractor2 : MonoBehaviour
{
	/*
	 * Class members
	 */
	public bool m_UseLocalVector = true;
	public float m_Gravity2 = -10.0f;
	
	
	/*
	 * Public attract class method
	 */
	public void Attract(FauxGravityBody2 body)
	{
		// Create local variables
		Vector3 gravityUp;
		Transform trans = body.transform;
		Rigidbody rigid = body.rigidbody;

		// Set gravity local variable
		gravityUp = trans.position - this.transform.position;
		gravityUp.Normalize();

		
		// Apply forces to body
		rigid.AddForce(gravityUp * this.m_Gravity2 * rigid.mass);
		
		// Check value of bodys grounded value
		if(body.Grounded2 >= 1)
		{
			// Set rigid body drag
			rigid.drag = 0.1f;
		}
		else
		{
			// Set rigid body drag
			rigid.drag = 1.0f;
		}
		
		// Check value of rotation freeze
		if(rigid.freezeRotation == true)
		{
			// Calculate quaternion
			Quaternion quatern = Quaternion.FromToRotation(trans.up, gravityUp);
			quatern = quatern * trans.rotation;
			
			// Calculate rotation of body
			trans.rotation = Quaternion.Slerp(trans.rotation, quatern, 0.1f);
		}
	}
}
