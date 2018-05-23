using System.Collections;
using UnityEngine;

public class FallFloor : MonoBehaviour {
	//床が落下するまでの時間
	private float timeToFall = 5f;

	//操作キャラが乗っているトータルの時間
	private float totalltime = 0;
	private Rigidbody rigid; 

	void Start (){
		rigid = GetComponent<Rigidbody> ();
		rigid.isKinematic = true
	}

	void Update (){
		if(totalTime > = timeFall) {
			rigid.isKinematic = false;
		}
	}

		public ReceiveForce(){
			totalTime += Time.deltaTime;
		}




	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("Player")){
			Invoke("Fall",2);

		}
	}

	void Fall (){
		GetComponent<Rigidbody>().isKinematic = false;
	}
}
