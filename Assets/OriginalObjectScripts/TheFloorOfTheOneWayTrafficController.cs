using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFloorOfTheOneWayTrafficController: MonoBehaviour {

	private int player_layer;
	private int sliding_floor_layer;


	void Start () {
		//各レイヤーの情報取得
		player_layer = LayerMask.NameToLayer("Player");
		sliding_floor_layer = LayerMask.NameToLayer("SlidingFloor");
	}

	private void OnChildTriggerEnter(Collider c) {
		if (c.gameObject.tag == "TriggerCollider") {
			Physics.IgnoreLayerCollision (player_layer, sliding_floor_layer);
		}
	}

	private void OnTriggerExit(Collider c) {
		if (c.gameObject.tag == "TriggerCollider") {
			Physics.IgnoreLayerCollision(player_layer, sliding_floor_layer, false);
		}
	}
}
