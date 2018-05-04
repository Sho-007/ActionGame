using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	Animation anim;
	BoxCollider boxCollider;
	public int hp = 100;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		boxCollider = GetComponent<BoxCollider> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "unitychan") {
			hp -= 50;
			print (hp);
			if (hp <= 0) {
				anim.Play ("FighterMediumPrehab");
				Destroy (boxCollider);
			}
		}
	}
}

