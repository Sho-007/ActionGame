using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageMeausurement : MonoBehaviour {




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (invisibleFlag)
{
    blinkTimer += Time.deltaTime;
    if (blinkTimer > blinkInterval)
    {
        // 点滅させる
        playerMesh.enabled = !playerMesh.enabled;
        blinkTimer = 0;
    }

    invisibleTimer += Time.deltaTime;
    if (invisibleTimer > invisibleInterval)
    {
        // 無敵時間終了
        invisibleTimer = 0;
        invisibleFlag = false;

        playerMesh.enabled = true;
    }
}

// 体当たりしてきた敵とプレイヤーの座標からノックバックする方向を取得する
Vector3 knockBackDirection = (enemy.transform.position - player.transform.position).normalized;

// ノックバックの方向を逆転させる（強制的にバウンドさせるのでYは「1」固定）
knockBackDirection.x *= -1;
knockBackDirection.y = 1;
knockBackDirection.z += -1;

// ノックバックさせる（ノックバックの強さは敵から取得）
move.knockBack(knockBackDirection, enemyScript.GetKnockBackPower());
	}
}
