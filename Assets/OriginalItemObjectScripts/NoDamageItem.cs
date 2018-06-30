using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDamageItem : MonoBehaviour {

	public GameObject Destroyeffect;
	public AudioClip get_audio;
	public GameObject NoDamageItem_get_effect;

	private GameObject noDamageItem;

	void Start(){
		StartCoroutine ();
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			Destroy (gameObject);
			Instantiate (Destroyeffect, transform.position, transform.rotation);
			AudioSource.Play (get_audio);
		}
	}

	void Update(){
				


	}



IEnumerator NodamageItem(){
			print(Time.time);
	Destroy (Destroyeffect);
	Destroy (get_audio);
	yield return new WaitForSeconds (0.5f);
}
}