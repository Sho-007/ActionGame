using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGravitation : MonoBehaviour {

	public GameObject Road;
	public float coefficient;

	void FixedUpdate () {
		// 道に向かう向きの取得
		var direction = Road.transform.position - transform.position;
		// 道までの距離の２乗を取得
		var distance = direction.magnitude;
		distance *= distance;
		// 万有引力計算
		var gravity = coefficient * Road.rigidbody.mass * rigidbody.mass / distance;

		// 力を与える
		rigidbody.AddForce(gravity * direction.normalized, ForceMode.Force);
	}

	try {
		Road.RatGardRoad = 
		
}