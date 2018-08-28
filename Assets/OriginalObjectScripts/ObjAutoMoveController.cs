using System.Collections;
using UnityEngine;

public class ObjAutoMoveController : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time,10), transform.position.z);
	}
}
