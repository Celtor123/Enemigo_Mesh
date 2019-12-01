using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
    public UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	public GameObject fin;
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
		
		Transform a= fin.GetComponent<Transform>();
		agent.SetDestination(a.position);
	}
}
