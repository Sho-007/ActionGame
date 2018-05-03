using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBarController : MonoBehaviour {
	Animation anim;
	BoxCollider boxCollider;
	int hp = 100;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		boxCollider = GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
		void OnTriggerEnter(Collider other) {
			if (other.name == "cutter01") {
				anim.Play ("Allosaurus_Die");
				Destroy (boxCollider);
			}
	}
}
