using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private bool alive;

	// Use this for initialization
	void Awake () 
	{
		alive = true;
	}

	void Update()
	{
		
	}

	public bool IsAlive() 
	{
		return alive;
	}

	public void Living(bool status) 
	{
		alive = status;
	}
}
