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
		if(state == EnemyState.Walk || state == EnemyState.Chase) {
		//　キャラクターを追いかける状態であればキャラクターの目的地を再設定
		if (state == EnemyState.Chase) {
			setPosition.SetDestination (playerTransform.position);
		}
		if (enemyController.isGrounded) {
			velocity = Vector3.zero;
			animator.SetFloat ("Speed", 2.0f);
			direction = (setPosition.GetDestination () - transform.position).normalized;
			transform.LookAt (new Vector3 (setPosition.GetDestination ().x, transform.position.y, setPosition.GetDestination ().z));
			velocity = direction * walkSpeed;
		}
 
		//　目的地に到着したかどうかの判定
		if (Vector3.Distance (transform.position, setPosition.GetDestination ()) < 0.7f) {
			SetState ("wait");
			animator.SetFloat ("Speed", 0.0f);
		}
	//　到着していたら一定時間待つ
	} else if(state == EnemyState.Wait) {
		elapsedTime += Time.deltaTime;
 
		//　待ち時間を越えたら次の目的地を設定
		if(elapsedTime > waitTime) {
			SetState ("walk");
		}		
	}
	velocity.y += Physics.gravity.y * Time.deltaTime;
	enemyController.Move (velocity * Time.deltaTime);
}
}
