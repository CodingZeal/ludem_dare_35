using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {

	public float thrust;
	public int bpm;
	public Rigidbody rb;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() 
	{
		rb.AddForce(transform.forward * thrust);
	}
}
