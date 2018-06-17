using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class Bullet2 : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		GameObject unitychan  = GameObject.Find("unitychan");
		float speed = 1.0f
		float step = Time.deltaTime*speed;
		transform.position = Vector3.MoveTowards(transform.position, unitychan.transform,position, step);
	}		

	void OnCollisionEnter(otherObjct.Collision){
		if(otherObject.tag = "Player"){
			
	}
	}



		

