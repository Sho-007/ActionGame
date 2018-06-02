using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFloorOfTheOneWayTrafficController: MonoBehaviour {

	private BoxCollider fllorCollider;

	void Start () {
		fllorCollider = this.GetComponent<BoxCollider>();
	}

	private void OnChildTriggerEnter(Collider c) {
		if (c.gameObject.tag == "TriggerCollider") {
			fllorCollider.isTrigger = true;
		}
	}

	private void OnTriggerExit(Collider c) {
		if (c.gameObject.tag == "TriggerCollider") {
			fllorCollider.isTrigger = false;
		}
	}
}
