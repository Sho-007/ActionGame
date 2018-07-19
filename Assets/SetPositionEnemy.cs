using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositionEnemy : MonoBehaviour {

	//出現戦闘機エネミーの初期位置
	private Vector3 startPosition;

	//出現エネミーの目的地
	private Vector3 destination;




	// Use this for initialization
	void Start () {
		//スタートポジションの設定
		startPosition = transform.position;
		SetDestinaition(transform.position);
	}


	public void CreateRandomPosition(){
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
