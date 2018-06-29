using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour {


	GameObject player;
	PlayerHP hpcomp;
	Slider hpslider;
	private int hp;





	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		hpcomp = player.GetComponent <PlayerHP> ();
		hpslider = GameObject.Find ("HPBar").GetComponent<Slider> ();
		//最大hpの値
		hp = 100;
		//sliderのValueの値を最大値にする
		hpslider.value = hp;

	}
	
	// Update is called once per frame
	void Update () {
		//PlayerHP内の変数HPをPyHPを使用
		int PyHP = hpcomp.HP;
		//Valueの値をPyHPにする
		hpslider.value = PyHP;
	}
}
