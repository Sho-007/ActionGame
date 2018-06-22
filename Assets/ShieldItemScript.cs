using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItemScript : MonoBehaviour {

	//ぶつかってくるエネミーの射撃攻撃を防ぐ
	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("EnemyBullets")) {
			Destroy (other.gameObject);
		}
	}
}
