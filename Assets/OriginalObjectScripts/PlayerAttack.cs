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

		// 地上にいるときに下入力した場合の処理
		if (Input.GetAxis("Vertical") < -0.5f && charMotor.IsGrounded()) {
			// すり抜け床の上にいる場合はレイヤーマスク変更
			int sliding_floor_layer = LayerMask.NameToLayer("SlidingFloor");
			if (Physics.Raycast(transform.position, -transform.up, sliding_floor_layer)) {
				int player_layer = LayerMask.NameToLayer("Player");
				Physics.IgnoreLayerCollision(player_layer, sliding_floor_layer);
			}








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