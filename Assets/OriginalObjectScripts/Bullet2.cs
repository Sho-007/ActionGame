using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour {

	public string name = "bullet2";
	Bullet2 GameObject;
	public float speed = 3f; //弾の速度

	// Use this for initialization
	void Start () {
		//弾を3秒後に発射する
		Destroy (this.gameObject,3);

	}
	
	// Update is called once per frame
	void Update () {
		//弾を移動
		if(EnemyTargetTrigger)
			{
				//runcherbulletにbulletのインスタンスを格納
				GameObject runcherBullet = GameObject.Instantiate("bullet2") as GameObject; 
				//アタッチしているオブジェクト前方にbullet speedの速さで発射
				runcherBullet.GetComponent<Rigidbody>().velocity = transform.forward * speed;
				runcherBullet.transform.position = transform.position;

			}
			transform.Translate(transform.forward * Time.deltaTime * speed);
		
			}
}

