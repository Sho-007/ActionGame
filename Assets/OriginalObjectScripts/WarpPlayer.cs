using UnityEngine;
using System.Collections;

public class WarpPlayer : MonoBehaviour {

	public enum WarpPlayerState {
		normal,
		goToWarpPoint,
	};

	private CharacterController characterController;
	private Animator animator;
	private Vector3 velocity = Vector3.zero;
	private WarpPlayerState state;
	private Transform waitPoint;
	private Transform warpPoint;
	// InstantiateParticle instantiateParticle;
	//　歩く速さ
	public float walkSpeed;
	//　ワープポイントでキャラクターを中央に移動させたり回転させたりするスピード
	public float goToWaitPointSpeed;
}