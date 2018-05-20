using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDamageItem : MonoBehaviour {

	public GameObject Destroyeffect;
	public AudioClip get_audio;
	public GameObject NoDamageItem


	if (other.gameObject.tag == "Player") {
		Destroy (gameObject);
		Instantiate (Destroyeffect, transform.position, transform.rotation);
		AudioSource.PlayClipAtPoint (get_audio, Camera.main.transform.position);
		StartCoroutine ("destroy_effect");
	}
}

IEnumerator destroy_effect()
{
	yield return new WaitForSeconds (0.5f);
	Destroy (Destroyeffect);
	Destroy (get_audio);
}
}