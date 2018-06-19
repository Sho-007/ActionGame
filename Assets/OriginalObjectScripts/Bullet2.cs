using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class Bullet2 : MonoBehaviour {

	//弾のプレハブ　クローン
	public GameObject bullet2;
	GameObject  bulletClone;

	//武器の先端
	public Transform tip;


	//弾速度
	public float speed = 5000;

	//連射時設定
	private float time 0f;
	public float interval = 0.3f;

	void Start(){
		
	}



	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		GameObject unitychan  = GameObject.Find("unitychan");
		float speed = 1.0f
		transform.position = Vector3.MoveTowards(transform.position, unitychan.transform,position, step);
	}		

	void OnCollisionEnter(otherObjct.Collision){
		if(otherObject.tag = "Player"){
			
	}
	}



		

