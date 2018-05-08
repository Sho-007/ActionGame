using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加する要素
using UnityEngine.AI;

public class Chase : MonoBehaviour {
	public Transform target;
	public Transform[] targets;
	public NavMeshAgent agent;
	public 

	public GameObject target;
	private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

		//ターゲットの位置を目的地に設定する。
		agent.destination = target.transform.position;
	}
}
