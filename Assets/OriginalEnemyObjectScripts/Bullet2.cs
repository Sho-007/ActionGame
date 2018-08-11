using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using System;

public class Bullet2 : MonoBehaviour {

	//弾のプレハブ　クローン
	public GameObject TrackingBullet;

	//武器の先端
	public Transform tip;


	//弾速度
	public float speed;

	//連射時設定
	private float time = 0f;
	public float interval = 0.3f;

	void Start(){
		transform.Translate(transform.forward * Time.deltaTime * speed);
	}



	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		float step = speed * Time.deltaTime;
		GameObject unitychan  = GameObject.Find("unitychan");
		float speed = 1.0f;
		transform.position = Vector3.MoveTowards(transform.position, unitychan.transform.position,step);
	}		

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Player"){
			Destroy(col.gameObject);
		}
			
	}
	}



		

