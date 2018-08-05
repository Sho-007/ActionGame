using System.Collections;
using UnityEngine;

public class EnemyTargetTrigger : MonoBehaviour {
	




	void Start(){
		enemyController = GetComponent <CharacterController> ();
		animator = GetComponent <Animator> ();
		SetPositionEnemy = GetComponent <SetPositionEnemy> ();
		setPosition.CreateRandomPosition ();
		velocity = Vector3.zero;
		arrived = false;
		elapsedTime = 0f;
		SetState　("wait");
	}




	void OnTriggerStay(Collision collision){
		//プレイヤーの発見
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


	void Update(){
	
	}



	//　敵キャラクターの状態変更メソッド
	public void SetState(string mode, Transform obj = null) {
		if(mode == "walk") {
			arrived = false;
			elapsedTime = 0f;
			state = EnemyState.Walk;
			setPosition.CreateRandomPosition ();
		} else if(mode == "chase") {
			state = EnemyState.Chase;
			//　待機状態から追いかける場合もあるのでOff
			arrived = false;
			//　追いかける対象をセット
			playerTransform = obj;
		} else if(mode == "wait") {
			elapsedTime = 0f;
			state = EnemyState.Wait;
			arrived = true;
			velocity = Vector3.zero;
			animator.SetFloat ("Speed", 0f);
		}
	}



}
