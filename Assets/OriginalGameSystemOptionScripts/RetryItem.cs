using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




	void Retry(){
		this.gameObject.SetActive (true);
		PlayerHP = 5;
		PlayerHPSlider.value = PlayerHP;
	}

	public void AddHP(int amount){
		PlayerHP += amount;
		if (PlayerHP > 5)
			PlayerHP = 5;
		PlayerHPSlider.value = playerHP;
	}

	// 追加（自機1UPアイテム）
	public void Player1Up(int amount){

		// amount分だけ自機の残機を回復させる。
		DestroyCount -= amount;

		// 最大残機数を超えないようにする（破壊された回数が０未満にならないようにする）
		if (destroyCount < 0)
			destroyCount = 0;

		// 残機数を表示するUI（アイコン）
		for(int i = 0; i < playerIcons.Length; i++){
			if (destroyCount <= i)
				playerIcons [i].SetActive (true);
			else
				playerIcons [i].SetActive (false);
		}
	}
}
