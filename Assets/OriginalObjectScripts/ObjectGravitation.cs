using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGravitation : MonoBehaviour {

	public Vector3 localGravity;
	public Rigidbody rb;
	public float coefficient;
	GameObject RatGuardRoad;
	GameObject unitychan;

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "RatGuardRoad") {
			if (collision.gameObject.tag == "GravitationRoad") {
			}
		}
	}

	void Start(){
		rb = unitychan.GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
				SetLocalGravity();
		// 道に向かう向きの取得
		var direction = RatGuardRoad.transform.position - transform.position;
		// 道までの距離の２乗を取得
		var distance = direction.magnitude;
		distance *= distance;
		// 万有引力計算
		var gravity = coefficient * rb.mass * rb.mass / distance;

		// 力を与える
		rb.AddForce(gravity * direction.normalized, ForceMode.Force);
	}

			void SetLocalGravity(){
		rb.AddForce (localGravity, ForceMode.Acceleration);
	}
	}