using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItemScript : MonoBehaviour {


	public GameObject effectPrefab;
	public AudioClip getSound;
	public GameObject shieldPrehab;

	private GameObject unitychan;
	private Vector3 pos;

	void OnTriggerEnter(Collider.other){
		if(other.CompareTag("EnemyBullets")){
			//エフェクトと効果音を発生させる
			Instantiate(effectPrefab,transform.position,Quaternion.identity);
			AudioSource.PlayClipAtPoint (getSound,Camera.main.transform.position);

			//プレイヤーの位置情報を取得する
			unitychan = GameObject.FindWithTah("Player");
			pos = unitychan.transform.position;


			//プレイヤーの側面に




	}



















	//ぶつかってくるエネミーの射撃攻撃を防ぐ
	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("EnemyBullets")) {
			Destroy (other.gameObject);
		}
	}
}
