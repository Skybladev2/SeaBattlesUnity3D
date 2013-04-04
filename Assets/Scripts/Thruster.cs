using UnityEngine;
using System.Collections;

/// <summary>
/// Тяговый двигатель. Прикладывает силу к массе. Повторяет все перемещения массы, так как находится (по умолчанию) в той же точке.
/// </summary>
public class Thruster : MonoBehaviour
{
	protected Vector3 facing
	{
		get
		{
			return this.transform.up;
		}
	}
	/// <summary>
	/// По умолчанию тяговый двигатель смотрит в ту же сторону, что и родитель.
	/// </summary>
	protected float angleFromParentFacing = 0;
	protected float maxForce = 10;

	public bool IsOn = false;	
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{		
		
	}	
	
	public Vector3 GetForce ()
	{	
		if (IsOn)
		{						
			return facing * maxForce;
		}
		else
		{
			return Vector2.zero;
		}
	}
}
