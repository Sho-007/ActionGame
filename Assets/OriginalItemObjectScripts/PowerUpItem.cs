﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : MonoBehaviour {

	public GameObject effectPrefab;
	public AudioClip getSound;
	private GameObject fireMissilePod1;
	private GameObject fireMissilePod2;

	void Start(){
		fireMissilePod1 = GameObject.Find ("FireMissileB");
		fireMissilePod2 = GameObject.Find ("FireMissileC");
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Missile")) {

			// エフェクトを発生させる
			Instantiate (effectPrefab, transform.position, Quaternion.identity);

			// 効果音を出す
			AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);

			// アイテムを画面から消す（非アクティブ状態にする）（ポイント）
			// ここでアイテムを破壊（Destror）するとメモリ上から消えて「Nomalメソッド」が実行されなくなるので注意！
			this.gameObject.SetActive(false);

			// 「FireMissile」スクリプトを有効にする。（ポイント）
			fireMissilePod1.GetComponent<FireMissile> ().enabled = true;
			fireMissilePod2.GetComponent<FireMissile> ().enabled = true;

			// 3秒後に元の状態（攻撃力）に戻す。
			Invoke ("Normal", 3);
		}
	}

	// プレーヤーの攻撃力を元に戻すメソッド
	void Normal(){

		// 「FireMissile」スクリプトを無効にする。（ポイント）
		fireMissilePod1.GetComponent<FireMissile> ().enabled = false;
		fireMissilePod2.GetComponent<FireMissile> ().enabled = false;

		// アイテムを破壊する（メモリ上から消す）
		Destroy (this.gameObject);
	}
}