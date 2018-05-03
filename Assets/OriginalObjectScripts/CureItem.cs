using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureItem : MonoBehaviour {

	public GameObject effectPrefab;
	public AudioClip getSound;
	private PlayerHealth playerHealth;
	private int reward = 3;

	void Start(){
		// 「Player」についている「PlayerHealth」スクリプトにアクセスする。
		playerHealth = GameObject.Find ("Player").GetComponent<PlayerHealth> ();
	}


	void OnTriggerEnter(Collider other){
		// プレーヤーのミサイルで破壊するとHPが回復する
		if (other.gameObject.CompareTag ("Missile")) {

			// エフェクトを発生させる
			Instantiate (effectPrefab, transform.position, Quaternion.identity);

			// 効果音を出す
			AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);

			// アイテムを画面から消す（破壊する）
			Destroy(this.gameObject);

			// プレーヤーのHPを３つ回復させる
			playerHealth.AddHP(reward);
		}
	}
}