using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {


	public GameObject unitychan;
	public GameObject mainCamera;






	// Use this for initialization
	void Start () {
		mainCamera = UnityEngine.Camera.main.gameObject;
		unitychan = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		transform.position = unitychan.transform.position;
	}
}

