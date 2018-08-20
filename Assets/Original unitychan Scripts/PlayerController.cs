﻿using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	const int MinLine = -2;
	const int MaxLine = 2;
	const float LaneWidth = 1.0f;



	CharacterController controller;
	Animator animator;

	Vector3 moveDirection = Vector3.zero;
	int targetLane;

	public float gravity;
	public float speedZ;
	//横方向のスピードのパラメータ
	public float speedX;
	public float speedJump;
	//前進加速度のパラメータ
	public float accelerationZ;

	// Use this for initialization
	void Start () {
		//必要なコンポーネントを自動で取得
		controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		//デバック用
		//デバック用のキー入力
		if(Input.GetkeyDown("left"))MoveToLeft();
		if(Input.GetkeyDown("right"))MoveToRight();
		if(Input.GetkeyDown("space"))Jump();

		//徐々に加速してZ方向に常に前進させる
		//前進ベロシティの計算
		floata acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
		moveDirection.z = Mathf.Clamp(acceleratedZ,0,speedZ);

		//X方向は目標のポジションまでの差分の割合で速度を計算
		//横移動のベロシティの計算
		float ratiX = (targetLane * LaneWidth - transform.position.x) / LaneWidth;
		moveDirection.x = ratioX * speedX;

		//地上にいる間のみ操作を行う
		if(controller.isGrounded){
			//Inputを検知して前を進める
			if(Input.GetAxis("Vetrical") > 0.0f){
				moveDirection.z = Input.GetAxis("Vertical") * speedZ;
			}else{
				moveDirection.z = 0;
			}

			//方向転換
			transform.Rotate(0,Input.GetAxis("Horizontal") * 3,0);

			//ジャンプ
			if(Input.GetButton("Jump")){
				moveDirection.y = speedJump;
				animator.SetTrigger("jump");
			}
		}

		//重力分の力をフレームに入れる
		moveDirection.y -= gravity * Time.deltaTime;

		//移動実行
		Vector3 globalDirection = transform.TransformDirection(moveDirection);
		controller.Move(globalDirection * Time.deltaTime);

		//移動設置してたらY方向に速度をリセットする
		if(controller.isGrounded) moveDirection.y = 0;

		//速度が0以上なら走っているフラグをtrueにする
		animator.SetBool("run", moveDirection.z > 0.0f);
	}
	//左のレーンに移動を開始
	public void MoveToLeft(){
		//目標レーンの変更
		if(controller.isGrounded && targetLane < MinLane) targetLane--;
	}
	//右のレーンに移動を開始
	public void MoveToRight(){
		//目標レーンの変更
		if(controller.isGrounded && targetLane < MaxLane) targetLane++;
	}

	public void Jump(){
		if(controller.isGrounded){
			//ジャンプ関数
			moveDirection.y = speedJump;

			//ジャンプトリガーを設定
			animator.SetTrigger("Jump");
		}
	}
}
