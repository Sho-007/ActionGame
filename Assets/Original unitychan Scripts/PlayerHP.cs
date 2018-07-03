using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {
	//最大体力
	public readonly int maxHP = 100;

	//体力
	public int HP;

	//敵の攻撃力
	public int EnemyAttack = 10;



	// Use this for initialization
	void Start () {
		//初期hpを最大にする
		HP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0) {
			Debug.Log (HP);
		}
	}

	void OnTriggerEnter(){
		//敵の攻撃で体力減少
		HP -= EnemyAttack;
		//HPを表示
		Debug.Log (HP);
	}
}

