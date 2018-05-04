using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	private Animator anim;
	public AudioClip punchSound;
	void Start () {

		anim = GetComponent<Animator> ();	
	}

	void Update () {

		// Qボタンを押すとパンチ
		if (Input.GetKeyDown (KeyCode.Q)) {
			anim.SetBool ("Jab", true);
			AudioSource.PlayClipAtPoint (punchSound, Camera.main.transform.position);
		}

		// Eボタンを押すとハイキック
		if (Input.GetKeyDown (KeyCode.E)) {
			anim.SetBool ("Hikick", true);
		}

		// Sボタンを押すと回転キック
		if (Input.GetKeyDown (KeyCode.S)) {
			anim.SetBool ("Spinkick", true);
		}

		// Zボタンを押すとムーンソルトキック
		if (Input.GetKeyDown (KeyCode.Z)) {
			anim.SetBool ("SAMK", true);
		}
	}
}