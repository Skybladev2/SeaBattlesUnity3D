using UnityEngine;
using System.Collections;

/// <summary>
/// Тяговый двигатель. Прикладывает силу к массе. Повторяет все перемещения массы, так как находится (по умолчанию) в той же точке.
/// </summary>
public class Thruster : MonoBehaviour
{
	private Physics physics = null;
	
	protected Vector2 facing;
	/// <summary>
	/// По умолчанию тяговый двигатель смотрит в ту же сторону, что и родитель.
	/// </summary>
	protected float angleFromParentFacing = 0;
	protected float maxForce = 10;
	//protected bool isOn = false;

	public bool IsOn = false;
	/*{
		get {
			return isOn;
		}
		set {
			isOn = value;
		}
	}*/
	
	
	// Use this for initialization
	void Start ()
	{
		physics = this.GetComponent<Physics> ();
		facing =  new Vector2(0, 1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}	
	
	public Vector2 GetForce ()
	{
		Debug.Log(IsOn);
		
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
