using UnityEngine;
using System.Collections;

public class Physics : MonoBehaviour
{
	public ThrusterController thrusterController = null;	
	private float angle = 0;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void FixedUpdate()
	{		
		//this.rigidbody.rotation = Quaternion.AngleAxis((angle++ * 0.1f), Vector3.forward);
		
		//Vector3 thrusterForce =  thrusterController.GetForce();
		//Vector3 environmentForce = ApplyEnvironmentForce();
		//float velocityDt = (thrusterForce + environmentForce).magnitude * Time.deltaTime;		
		
		Vector3 torque = thrusterController.GetTorque();
		Vector3 environmentTorque = ApplyEnvironmentTorque();
		rigidbody.AddRelativeTorque(torque);
		rigidbody.AddRelativeTorque(environmentTorque);
		this.rigidbody.velocity = this.transform.up * 10;				
	}
	
	private Vector3 ApplyEnvironmentForce()
	{		
		Vector3 waterResistance = -this.rigidbody.velocity;
		return waterResistance;
	}
	
	private Vector3 ApplyEnvironmentTorque()
	{
		Vector3 waterRotationResistance = - this.rigidbody.angularVelocity.magnitude * 100 * Mathf.Sign(this.rigidbody.angularVelocity.z) * Vector3.forward;
		return waterRotationResistance;
	}	
}
