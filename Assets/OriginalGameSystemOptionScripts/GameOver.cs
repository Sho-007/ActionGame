using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	void  OnGUI (){

		GUIStyle guiStyle = new GUIStyle();
		GUIStyleState styleState = new GUIStyleState();

		styleState.textColor = Color.black;

		guiStyle.normal = styleState;
		guiStyle.fontSize = 120;

		GUI.Label( new Rect(10, 10, 300, 100), "Game Over !!", guiStyle);
	}
}
