using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlockController : MonoBehaviour {

	private GameObject Parent;

	void Start()
	{
		Parent = transform.parent.gameObject;
	}

	private void OnTriggerEnter(Collider c)
	{
		Parent.SendMessage("OnChildTriggerEnter", c);
	}
}
