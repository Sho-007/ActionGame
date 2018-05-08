using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour {
	public float;

	// Use this for initialization
	void Start () {
		//弾を3秒後に発射する
		Destroy (this.gameObject,3);
	}
	
	// Update is called once per frame
	void Update () {
		//弾を移動
		transform.Translate (transform.forward * Time.deltaTime * speed);
		
	}

	 if (Input.GetKeyDown("space"))
    {
		//runcherbulletにbulletのインスタンスを格納
        GameObject runcherBullet = GameObject.Instantiate(bullet) as GameObject; 
		//アタッチしているオブジェクト前方にbullet speedの速さで発射
        runcherBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        runcherBullet.transform.position = transform.position;
	}
}

