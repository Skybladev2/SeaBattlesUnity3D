using UnityEngine;
using System.Collections;

public class Physics : MonoBehaviour
{
	public ThrusterController thrusterController = null;
	/*public Vector3 resultantForce = Vector3.zero;
	
	public void ApplyForce(Vector2 force)
	{
		resultantForce += new Vector3(force.x, force.y);
	}*/
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate()
	{
		Vector2 thrusterForce =  thrusterController.GetForce();		
		Vector3 environmentForce = ApplyEnvironmentForce();
		
		this.rigidbody.AddForce(new Vector3(thrusterForce.x, thrusterForce.y));		
		this.rigidbody.AddForce(environmentForce);		
	}
	
	private Vector3 ApplyEnvironmentForce()
	{
		Vector3 waterResistance = -this.rigidbody.velocity.magnitude * transform.up;
		return waterResistance;
	}
	
}
