using System
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加する要素
using UnityEngine.AI;

public class Chase : MonoBehaviour {
	public Transform target;
	public Transform[] targets;
	public NavMeshAgent agent;
	public  current target = 0 ;
	current target = currentTarget;
	currentTarget = "unitychan"



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
		if (Vector3.Distance(transform.position, target.position) < 1) {
            if (currentTarget < targets.Length - 1) {
                currentTarget += 1;
            }
            else {
                currentTarget = 0;
            }
        }

        target = targets[currentTarget];

        if (target != null) {
            agent.SetDestination (target.position);
        }


	}
}
