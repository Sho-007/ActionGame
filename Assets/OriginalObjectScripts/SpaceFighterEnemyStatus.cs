using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceFighterEnemyStatus : MonoBehaviour {
	#region "変数・定数の宣言"
	//体力
	float health;

	//生死判別フラグ
	bool dieFlg = false;                         

	//アイテム設定
	public GameObject pickup1; //アイテム１
	public GameObject pickup2; //アイテム２
	public GameObject pickup3; //アイテム３
	public GameObject pickup4; //アイテム４
	
	//定数
	float healthMax = 60.0f;   //最大体力

	//持てるアイテムの設定
	int numHelditemsMin = 1;  //最小アイテム所持数
	int numHelditemsMax = 3;  //最大アイテム所持数
	int dropItemRangeSt = 0;  //最小アイテム設定値
	int dropItemRangeEd = 10; //最大アイテム設定値
	#endregion

	#region "Load時処理"
	//Use this for intillization
	void start () {
		//体力セット
		health =Random.Range(CommonConst.SpaceFighterEnemyLifeSt.SpaceFighterEnemyLifeEd);

		//アイテムドロップ時に以下のコメントアウトを解除
		//Die();
	}
	#endregion

	#region "被ダメージ処理"
	//被ダメージ処理
	void ApplyDamage(float damage){
		//体力が0よりかつ、死亡していない場合
		if(health > 0 && dieFlg == false){
			health = health-damage;

			if(health < 1 && dieFlg !=true)
			dieFlg = true;
			Die();
		}
	}
	#endregion

	#region "死亡時処理"
	void Die(){

		//アイテムの落下ポジション保持
		var itemLocation= gameObject.transform.positon;

		//報酬はランダムなアイテムを個数落とす
		var rewardItems = Random.Range(numHeldItemsMin,numHeldItemsMax);

		for(var i = 0;i < rewardItems; i++){
			var randomItemLocation = itemLocation;
			randomItemLocation.x +=Random.Range(-2,2);
			randomItemLocation.y +=1;
			randomItemLocation.z +=Random.Range(-2,2);

			//ドロップアイテム設定値に合わせた範囲内での乱数を決定する
			int itemValue =Random.Range(dropItemsRangeSt,dropItemRangeEd);
			//乱数に応じて出現させるアイテムを変化させる
			switch (itemValue){
				case 10:
				Instantiate(pickup1,randomItemLocation,pickup1.transform.rotation);break;

				case 9:
				case 8:
				Instantiate(pickup2,randomItemLocation,pickup2.transform.rotation);break;

				case 7:
				case 6:
				case 5:
				Instantiate(pickup3,randomItemLocation,pickup3.transform.rotation);break;

				case 4:
				case 3:
				case 2:
				case 1:
				case 0:
				Instantiate(pickup4,randomItemLocation,pickup4.transform.rotation);break;
			}
		}

		//オブジェクトの削除
		Destroy(this.gameObject);
	}
}
	#endregion