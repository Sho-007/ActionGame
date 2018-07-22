using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

	private CharacterController enemyController;
	private Animator animator;
	//　目的地
	private Vector3 destination;
	//　SpaceFighterEnemyの通常飛行スピード
	[SerializeField]
	private float FlyghtSpeed = 1.0f;
	//　飛行速度
	private Vector3 velocity;
	//　移動方向
	private Vector3 direction;
	//到着フラグ
	private bool arrived;
	//スタート位置
	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		enemyController = GetComponent <CharacterController> ();
		animator = GetComponent <Animator> ();
		destination = new Vector3 (25f, 0f, 25f);
		velocity = Vector3.zero;
		arrived = false;
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if(!arrived){
		if(enemyController.isGrounded) {
			velocity = Vector3.zero;
			animator.SetFloat("Speed", 2.0f);
			direction = (destination - transform.position).normalized;
			transform.LookAt(new Vector3(destination.x, transform.position.y, destination.z));
			velocity = direction * FlyghtSpeed;
			Debug.Log (destination);
		}
		velocity.y += Physics.gravity.y * Time.deltaTime;
		enemyController.Move(velocity * Time.deltaTime);

		//目的地に到着したかどうかのフラグ
			if (Vector3.Distance (transform.position, destination) < 0.5f) {
				arrived = true;
				animator.SetFloat ("Speed", 0.0f);
			}
		}
	}
}
