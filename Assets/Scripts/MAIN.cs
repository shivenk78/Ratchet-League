﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAIN : MonoBehaviour {

    public GameObject redCar;
    public GameObject blueCar;
    public GameObject redGoal;
    public GameObject blueGoal;
    public GameObject blueText;
    public GameObject redText;
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Reset()
    {
        redCar.GetComponent<CarController>().Reset();
        blueCar.GetComponent<CarController>().Reset();
        ball.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
        ball.GetComponent<Rigidbody>().velocity = new Vector3(0.0f,0.0f,0.0f);
    }
}
