using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour {

	public AudioClip effectSound;
	public GameObject effectPrefab;

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Enemy")) {
			Destroy (other.gameObject);
			AudioSource.PlayClipAtPoint (effectSound, Camera.main.transform.position);

			GameObject effect = (GameObject)Instantiate (effectPrefab, other.transform.position, Quaternion.identity);
			Destroy (effect, 0.5f);
		}
	}
}