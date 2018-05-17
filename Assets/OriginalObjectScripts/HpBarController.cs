using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBarController : MonoBehaviour {
	public readonly int maxHP = 100;    //体力の最大値
	public int HP;    //体力
	public int EnemyATK = 10;　　//敵の攻撃力



	void Start(){
		HP = maxHP; //初期体力を最大値にする
	}


	void Update(){
		if (HP <= 0){
			Debug.Log("死亡しました");
		}
	}

	void OnTriggerEnter(Collider hit){ 

		if (hit.CompareTag("Bullet")){

			HP -= EnemyATK; //攻撃で体力が減少
			Debug.Log(HP); //HPを表示
		}
	}
}
