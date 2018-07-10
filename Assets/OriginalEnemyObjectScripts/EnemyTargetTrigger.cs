﻿using System.Collections;
using UnityEngine;

public class EnemyTargetTrigger : MonoBehaviour {


	GameObject tagObjects;

	void Start(){
	}




	void OnTriggerStay(Collision collision){
		//プレイヤーの発見
		if (gameObject.tag == "Player") {
		}
	}


	void Update(){
	//　プレイヤーキャラクターを発見
		if(gameObject.tag == "Player") {
		//　敵キャラクターの状態を取得
			MoveEnemy.SpaceFighterEnemyState state = GetComponentInParent <MoveEnemy>().State ();

		//　敵キャラクターが追いかける状態でなければ追いかける設定に変更
		if (state != MoveEnemy.SpaceFighterEnemyState.Chase) {
			Debug.Log ("プレイヤー発見");
			GetComponentInParent<MoveEnemy> ().SetState ("chase", col.transform);
		}
		}
	}

		public void Setstate(){
			
		}

}
