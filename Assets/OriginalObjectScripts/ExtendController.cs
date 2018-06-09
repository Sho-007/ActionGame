using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendController : MonoBehaviour {

	public GameObject gameObject;


	// Use this for initialization
	void OnTrigger () {
		if {(gameObject.tag =="EnemyDropObject")
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			StartCoroutine ("Nobasu");
		}
	}
	IEnumerator Nobasu(){
		for(int i = 0;i<320; i++){
			transform.localScale += new Vector3(-0.01f,0,0);
			yield return new WaitForSeconds(0.01F);
		}
}
