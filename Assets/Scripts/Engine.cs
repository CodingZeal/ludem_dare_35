using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {

	public float thrust;
	public static int bpm = 80;
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
