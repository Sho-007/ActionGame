using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour {

	public GameObject Cube

	// Use this for initialization
	void Start () {
		//gameobujectの取得
		Cube = GameObject.Find("CubeName");

		//今の色コンソールに出力
		Debug.Log(Cube.render.material.color);

		//青色に変更





	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
