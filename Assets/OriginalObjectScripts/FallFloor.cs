using System.Collections;
using UnityEngine;

public class FallFloor : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("Player")){
			Invoke("Fall",2);

		}
	}

	void Fall (){
		GetComponent<Rigidbody>().isKinematic = false;
	}
}
