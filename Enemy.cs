using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	NavMeshAgent agent;
	public GameObject attackTarget;
	// Use this for initialization
	void Start () {
		agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(attackTarget.transform.position);
	}
}
