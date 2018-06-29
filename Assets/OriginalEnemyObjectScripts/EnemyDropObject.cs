using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDropObject : MonoBehaviour {

	public GameObject[] Train;

	void Start ()
	{
		number = Random.Range (0, Train.Length);
		Instantiate(Train[number],transform.position,transform.rotation);
	}
}
