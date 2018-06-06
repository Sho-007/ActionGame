using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroughBlockController : MonoBehaviour {

	protected BoxCollider boxCollider;
	protected List<Rigidbody> separateBlocks;

	void Start()
	{
		boxCollider = GetComponent<BoxCollider>();
		separateBlocks = GetComponentsInChildren<Rigidbody>().ToList();
	}

	private void OnChildTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Player") {
			boxCollider.enabled = false;

			var random = new System.Random();
			var min = -3;
			var max = 3;
			separateBlocks.ForEach(r => {
				r.isKinematic = false;

				var vect = new Vector3(random.Next(min, max), 0, random.Next(min, max));
				r.AddForce(vect, ForceMode.Impulse);
			});
		}
	}
}
