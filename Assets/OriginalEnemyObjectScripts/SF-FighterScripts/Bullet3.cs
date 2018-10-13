using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3 : MonoBehaviour {

	private GameObject target;
	//発生するオブジェクトをInspectorから指定するよう
	public GameObject SpawnObject;
	//発生間隔
	public float interval = 3.0f;


	// Use this for initialization
	void Start () {
		//名前でオブジェクト特定b
		target = GameObject.Find("player");
		StartCoroutine("Spawn");
	}

	IEnumerator Spawn(){
		while (true) {
			//自分で付けた位置に、オブジェクトをインスタンス化してから生成する
			Instantiate(SpawnObject,transform.position,Quaternion.identity);
			yield return new WaitForSeconds (interval);
		}
	}





	// Update is called once per frame
	void Update () {
		this.gameObject.transform.LookAt (target.transform.position);
	}
}
