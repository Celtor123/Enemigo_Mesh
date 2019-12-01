using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
	// Use this for initialization
	public GameObject player;
	public float velocidad;
	void Start () {
		velocidad=10;
	}
	
	// Update is called once per frame
	void Update () {
           float movhorizontal=Input.GetAxis("Horizontal");
        float movvertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movhorizontal,0.0f,movvertical);
        Rigidbody rb=player.GetComponent<Rigidbody>();
		rb.AddForce(movimiento * velocidad);
		
		
	}
}
