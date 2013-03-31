using UnityEngine;
using System.Collections;

/// <summary>
/// Тяговый двигатель. Прикладывает силу к массе. Повторяет все перемещения массы, так как находится (по умолчанию) в той же точке.
/// </summary>
public class Thruster : MonoBehaviour
{
	protected Vector2 facing;
	/// <summary>
	/// По умолчанию тяговый двигатель смотрит в ту же сторону, что и родитель.
	/// </summary>
	protected float angleFromParentFacing = 0;
	protected float maxForce = 10;

	public bool IsOn = false;	
	
	// Use this for initialization
	void Start ()
	{
		facing =  new Vector2(0, 1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}	
	
	public Vector2 GetForce ()
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

	internal void SetRotation (Vector2 velocity)
	{
		// пока забиваем на angleFromParentFacing
		this.facing = velocity;
	}
}
