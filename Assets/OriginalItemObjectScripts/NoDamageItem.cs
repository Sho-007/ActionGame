using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDamageItem : MonoBehaviour {

	public GameObject Destroyeffect;
	public AudioClip get_audio;
	public GameObject NoDamageItem_get_effect;

	private GameObject NoDamageItem

	void Start(){
		StartCoroutine ();
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player"){
			Destroy(gameObject);
			Instantiate(Destroyeffect,transform.position,transform.rotation);
			AudioSource.P

	void Update(){


	}

	if(other.gameObject.tag == "Player") {
		Destroy (gameObject);
		Instantiate (Destroyeffect, transform.position, transform.rotation);
				AudioSource.PlayClipAtPoint (get_audio, Camera.main.transform.position);
		StartCoroutine ("destroy_effect");
	}
}

IEnumerator NoDamageItem(){
			print(Time.time);
	Destroy (Destroyeffect);
	Destroy (get_audio);
	yeild return new WaitForSeconds (0.5f);
}
}