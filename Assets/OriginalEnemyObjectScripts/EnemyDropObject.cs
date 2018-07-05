using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDropObject : MonoBehaviour {

	public GameObject[] Train;

	void Start ()
	{
		for (int number = 0;number < 10; number++)
		{
		number= Random.Range (0, Train.Length);
		Instantiate(Train[number],transform.position,transform.rotation);
		}
	}
}
