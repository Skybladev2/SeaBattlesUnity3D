using UnityEngine;
using System.Collections;

public enum RotateDirection
{
	CounterClockwise = -1,
	Off = 0,
	Clockwise = 1
}

public class RotationThruster : MonoBehaviour
{
	//private Vector2 leftFacing;
	public RotateDirection rotateDirection;
	
	private float maxForce = 10;
	
	// Use this for initialization
	void Start ()
	{
		//leftFacing = new Vector2 (-1, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public Vector3 GetTorque ()
	{	
		switch (rotateDirection)
		{
		case RotateDirection.Clockwise:
			return Vector3.forward * maxForce;
			
		case RotateDirection.CounterClockwise:
			return -Vector3.forward * maxForce;
			
			case RotateDirection.Off:
			return Vector3.zero;
			
			default:
			return Vector3.zero;
			break;
		}
	}
}
