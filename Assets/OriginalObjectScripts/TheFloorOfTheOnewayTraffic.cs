using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFloorOfTheOnewayTraffic : MonoBehaviour {

	public bool call_enter;
	public bool call_exit;

	private GameObject Parent;

	void Start () {
		Parent = transform.parent.gameObject;
	}

	private void OnTriggerEnter(Collider c) {
		if (call_enter) {
			Parent.SendMessage("OnChildTriggerEnter", c);
		}
	}

	private void OnTriggerExit(Collider c) {
		if (call_exit) {
			Parent.SendMessage("OnChildTriggerExit", c);
		}
	}
}
