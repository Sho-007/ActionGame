using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
	public Transform WarpPanel;

	voic OnTriggerEnter(Collider col) {
		if(col.tag == "Player"){
			//キャラクターの状態をワープ状態に変更
			col.gameObject.<WarpChara>().SetDate(WarpChara.WarpCharaState.goToWarpPoint,transform,WarpPanel = new Vector3(0,20,0);

		}
	}
}
