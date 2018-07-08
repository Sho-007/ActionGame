using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorScript : MonoBehaviour {

	public GameObject Cube;
	Renderer CubeRenderer;
	Material CubeMaterial;
	Color CubeColor;

	void awake(){
		
	}

	// Use this for initialization
	void Start () {

		CubeRenderer = GetComponent<Renderer>();

		CubeRenderer.material.color = Color.red;




		//gameobujectの取得
		Cube = GameObject.Find("CubeName");

		//今の色コンソールに出力
		Debug.Log(CubeRenderer.material.color);

		//青色に変更
		CubeRenderer.material.color = Color.blue;

		//変更後のコンソールに出力
		Debug.Log(CubeRenderer.material.color);

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){

			RaycastHit hit;
			//カメラから見たRay
		
			Ray ray = UnityEngine.Camera.ScreenPointToRay(Input.mousePosition);

				//Rayを投射してオブジェクトを検出
				if(Physics.Raycast(ray,out hit)){
					print(hit.collider.gameObject);
	}
				}
				}
}
