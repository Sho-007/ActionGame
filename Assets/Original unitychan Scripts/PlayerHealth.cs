using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public GameObject effectPrefab;
	public AudioClip destroySound;
	public int playerHP;
	private Slider playerHPSlider;
	public GameObject[] playerIcons;
	public int destroyCount = 0;

	void Start(){
		playerHPSlider = GameObject.Find ("PlayerHPSlider").GetComponent<Slider> ();
		playerHPSlider.maxValue = playerHP;
		playerHPSlider.value = playerHP;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("EnemyMissile")) {

			playerHP -= 1;
			playerHPSlider.value = playerHP;
			Destroy (other.gameObject);

			if (playerHP == 0) {
				destroyCount += 1;
				UpdatePlayerIcons();
				GameObject effect = Instantiate (effectPrefab, transform.position, Quaternion.identity) as GameObject;
				Destroy (effect, 1.0f);
				AudioSource.PlayClipAtPoint (destroySound, transform.position);
				this.gameObject.SetActive(false);

				if(destroyCount < 5)
					Invoke("Retry", 1.0f);
				else
					SceneManager.LoadScene("GameOver");
			}
		}
	}

	void UpdatePlayerIcons(){
		for(int i = 0; i < playerIcons.Length; i++){
			if (destroyCount <= i)
				playerIcons [i].SetActive (true);
			else
				playerIcons [i].SetActive (false);
		}
	}

	void Retry(){
		this.gameObject.SetActive (true);
		playerHP = 5;
		playerHPSlider.value = playerHP;
	}

	// ★追加（HP回復アイテム）
	// 「public」を付けること（ポイント）
	public void AddHP(int amount){

		// 「amount」分だけHPを回復させる
		playerHP += amount;

		// 最大HP以上には回復しないようにする。
		if (playerHP > 5)
			playerHP = 5;

		// HPスライダー
		playerHPSlider.value = playerHP;
	}
}
