using System.Collections;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour {

	public GameObject Cube;
	Renderer CubeRenderer;
	Material CubeMaterial;
	Color CubeColor;

	void awake(){
		
	}

	// Use this for initialization
	void Start () {

		CubeRenderer = GetComponent<Renderer>;

		CubeRenderer.material.color = Color.red




		//gameobujectの取得
		Cube = GameObject.Find("CubeName");

		//今の色コンソールに出力
		Debug.Log(Cube.render.material.color);

		//青色に変更
		Cube.renderer.material.color = Color.blue;

		//変更後のコンソールに出力
		Debug.Log(Cube.renderer.material.color);

	}
	// Update is called once per frame
	void Update () {
		Ray ray new Ray(Camera
	}
			void OnCollisionEnter(){
				
	}
}
