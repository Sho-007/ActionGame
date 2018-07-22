using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class DamageReturnArea : MonoBehaviour {
 
	public float power;

	private Transform returnPoint;
	private CameraController cameraController;

	void Start() {
		returnPoint = transform.Find("ReturnPoint");
	}

	void Update() {
		cameraController = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<CameraController>();
	}

	private void OnTriggerEnter(Collider c) {
		//string tag = TagUtility.getParentTagName(c.gameObject);

		if (tag == "Player") {
		//	c.GetComponent<Player>().forceDownDamage(this);
			StartCoroutine("returnCharacter", c.gameObject);

			// カメラアングルを固定
			cameraController.mainCamera = true;
		}
	}

	private IEnumerator returnCharacter(GameObject character) {
		yield return new WaitForSeconds(1f);

		cameraController.mainCamera = false;
		character.transform.position = returnPoint.position;
	}
}