using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeMetor : MonoBehaviour {


	// On the explosion object.
	void Start() {
		var exp = GetComponent<ParticleSystem>();
		exp.Play();
		Destroy(gameObject, exp.duration);
	}


	// Possible projectile script.
	public GameObject explosionPrefab;

	void Update() {
		RaycastHit hit;

		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit)) {
			Instantiate (explosionPrefab, hit.point, Quaternion.identity);
		}
	}
}