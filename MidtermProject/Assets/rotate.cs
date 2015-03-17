using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float time = 50;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (0,0,time*Time.deltaTime); //rotates 50 degrees per second around z axis
	}
}
