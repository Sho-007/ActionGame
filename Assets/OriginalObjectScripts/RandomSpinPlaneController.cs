﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpinPlaneController : MonoBehaviour {
	public float;
	public Vector3 centor;
	public Vector3 axis;

	// Use this for initialization
	void Start () {
		t = 0f;
		center = Vector3.zero; // ワールド座標の原点の周りに回転
		axis = Vector3.up;     // Y軸の周りに回転
		
	}
	
	// Update is called once per frame
	void Update () {
		if (t < 1f) {
      float prevT = t;
      t = Math.min(1f, t + Time.deltaTime); // 360度を超えないように
      float dt = t - prevT;
      transform.RotateAround(center, axis, 360 * dt);
    }
	}
}
