using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Restart : MonoBehaviour {

	public void RestartButton(){
	string sceneName = SceneManager.GetActiveScene ().name;
			SceneManager.LoadScene (sceneName);
		}
	}