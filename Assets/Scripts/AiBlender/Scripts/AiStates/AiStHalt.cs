﻿using UnityEngine;
using System.Collections;
/// <summary>
/// Basic FSM for doing nothing
/// </summary>
public class AiStHalt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable () {
		Debug.Log("hello halt");
	}

	void OnDisable () {
		Debug.Log("bye halt");
	}
}