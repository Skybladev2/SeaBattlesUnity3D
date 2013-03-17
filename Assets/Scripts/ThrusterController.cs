using UnityEngine;
using System.Collections;

public class ThrusterController : MonoBehaviour {
	
	public Thruster[] thrusters = new Thruster [2];
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//print(transform.forward);
		if (Input.GetButtonDown ("VerticalPad"))
		{
			if(Input.GetAxis("VerticalPad") > 0)
			{
				IncreaseSpeed ();
			}
			
			if(Input.GetAxis("VerticalPad") < 0)
			{
				DecreaseSpeed ();
			}
		}
	}
	
	private void DecreaseSpeed()
        {
            foreach (Thruster thruster in thrusters)
            {
                if (thruster.IsOn)
                {
                    thruster.IsOn = false;
                    break;
                }
            }
        }

        private void IncreaseSpeed()
        {
            foreach (Thruster thruster in thrusters)
            {
                if (!thruster.IsOn)
                {					
                    thruster.IsOn = true;
                    break;
                }
            }
        }
	
	public Vector2 GetForce()
	{
		Vector2 force = Vector2.zero;
		
		foreach (Thruster thruster in thrusters)
        {
			force += thruster.GetForce();
		}
		
		
		return force;
	}
}
