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


			//プレイヤーの側面に2枚のシールドを発生させる
			GameObject shieldA = (GameObject)Instantiate (shieldPrefab, new Vector3(pos.x - 0.5f, pos.y, pos.z),Quaternion.identity);
			GameObject shieldB = (GameObject)Instantiate (shieldPrefab,new Vector3(pos.x + 0.5f, pos.y, pos.z),Quaternion.identity);

			//発生させたシールドをプレーヤーの子供に設定する
			//親子関係にすることで一緒に動かす
			shieldA.transform.SetParent(unitychan.transform);
			shieldB.transform.SetParent(unitychan.transform);


			//発生させた防御シールドを5秒後に消滅させる
			Destroy(shieldA,5);
			Destroy(shieldB,5);

			//アイテムを破壊する
			Destroy(gameObject);
		}
	}
}
