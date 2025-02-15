﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[HideInInspector]

	public Vector3 targetPos;
	private float smoothMove=1f;

	// Use this for initialization
	void Start () {
		targetPos=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=Vector3.Lerp(transform.position,targetPos,smoothMove*Time.deltaTime);
	}
}
