using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceObject : MonoBehaviour {

//　Blockレイヤーを持つゲームオブジェクトと接触したら力を加える
	void OnControllerColliderHit(ControllerColliderHit col) {
		if(col.gameObject.layer == LayerMask.NameToLayer ("Block")) {
			col.rigidbody.AddForce(-col.normal * 100f);
		}
	}
}
 