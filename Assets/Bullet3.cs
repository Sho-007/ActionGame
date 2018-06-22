using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3 : MonoBehaviour {

	private GameObject target;



	// Use this for initialization
	void Start () {
		//名前でオブジェクト特定
		target = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		this.GameObject.transform.LookAt (target.transform.position);
	}
}
