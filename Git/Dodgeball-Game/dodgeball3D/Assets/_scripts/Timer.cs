﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	private Text timer; 
	private float tim;
	// Use this for initialization
	void Start () {
		timer = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		if (CameraController.isAlive) {
			tim += Time.deltaTime;
			CameraController.timeSurvived = tim;
			timer.text = "Time: " + Mathf.Round(tim).ToString ();
		} 

	}
}