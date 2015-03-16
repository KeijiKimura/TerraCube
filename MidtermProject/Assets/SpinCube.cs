using UnityEngine;
using System.Collections;
using Uniduino;

public class SpinCube : MonoBehaviour {

	public Arduino arduino;

	public int pin = 0;
	public int pinValue;
	public float spinSpeed = 0.2f;

	private GameObject cube;

	// Use this for initialization
	void Start () {
		arduino = Arduino.global;
		arduino.Setup (ConfigurePins);

		cube = GameObject.Find ("Cube");
	
	}

	void ConfigurePins () {
				arduino.pinMode (pin, PinMode.OUTPUT);
				arduino.reportAnalog (pin, 1);

		}
	
	// Update is called once per frame
	void Update () {
				pinValue = arduino.analogRead (pin);
				cube.transform.rotation = Quaternion.Euler (0, pinValue * spinSpeed, 0);
		}
	
	}

