﻿using System.Collections;
using UnityEngine;

public class Camera : MonoBehaviour {
	public GameObject target;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + offset;
	}
}
