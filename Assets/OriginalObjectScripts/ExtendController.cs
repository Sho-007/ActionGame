using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ExtendController : MonoBehaviour {

	public GameObject gameObject;
	float lockonMaxDistance;

	// ロックオン対象の敵を取得
	private GameObject GetTargetEnemy(bool isNearestPlayer = false, bool isScreenCentral = false)
	{
		var enemys = GameObject.FindGameObjectsWithTag("Enemy")
			//.Where(enemy => enemy.GetComponent<BaseEnemy>().IsVisible() == true)                                                    // 画面内にいるか
			.Where(enemy => UnityEngine.Camera.main.WorldToScreenPoint(enemy.transform.position).z > -(UnityEngine.Camera.main.transform.localPosition.z))   // カメラから見てプレイヤーより遠くにいるか
			.Where(enemy => Vector3.Distance(transform.position, enemy.transform.position) < lockonMaxDistance)                     // ロックオン可能範囲にいるか
			.Where(enemy => RaycastEnemy(enemy) == true);                                                                           // 射線が通るか

		// プレイヤーに一番近い敵を取得
		if (isNearestPlayer)
		{
			enemys = enemys.OrderBy(enemy => Vector3.Distance(transform.position, enemy.transform.position));
		}

		// 画面中央に一番近い敵を取得
		if (isScreenCentral)
		{
			enemys = enemys.OrderBy(enemy => Vector2.Distance(new Vector2(Screen.width / 2.0f, Screen.height / 2.0f), UnityEngine.Camera.main.WorldToScreenPoint(enemy.transform.position)));
		}

		return enemys.FirstOrDefault();
	}


	bool RaycastEnemy(GameObject enemy){
		return true;
	}










	// Use this for initialization
	void OnTrigger () {
		if (gameObject.tag =="EnemyDropObject"){
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			StartCoroutine ("Nobasu");
		}
	}
	IEnumerator Nobasu(){
		for(int i = 0;i<320; i++){
			transform.localScale += new Vector3(-0.01f,0,0);
			yield return new WaitForSeconds(0.01F);
		}
}
}
