using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour
{
	public GUIText velocityText;
	
	// (целевая) скорость на каждой передаче в м/с
    private float[] gears = new float[] { 0, 10, 20, 30 };
    // ускорения при переключении с 1 на 2, со 2 на 3 и т.д. передачу
    private float[] accelerations = new float[] { 2, 10, 2 };
    // ускорения при переключении со 2 на 1, с 3 на 2 и т.д. передачу
    private float[] decelerations = new float[] { -2, -10, -2 };
    // индекс передачи в массиве gears
    private int currentGear = 0;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{				
		if(velocityText != null)
		{
			velocityText.text = this.rigidbody.velocity.ToString();
		}
		
		
	}
	
	void FixedUpdate()
	{
		
	}
}
