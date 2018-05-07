using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManegement;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	public void GameStart () {
		SceneManager.LoadScene ("Main");
	}
}
