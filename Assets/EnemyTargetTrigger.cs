using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargetTrigger : MonoBehaviour {


	void Update(){
	//　プレイヤーキャラクターを発見
	if(col.tag == "Player") {
		//　敵キャラクターの状態を取得
		MoveEnemy.EnemyState state = GetComponentInParent <MoveEnemy> ().GetState ();
		//　敵キャラクターが追いかける状態でなければ追いかける設定に変更
		if (state != MoveEnemy.EnemyState.Chase) {
			Debug.Log ("プレイヤー発見");
			GetComponentInParent<MoveEnemy> ().SetState ("chase", col.transform);
		}
		}

}
