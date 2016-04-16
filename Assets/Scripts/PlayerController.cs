using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		moveHorizontal *= speed * -1;

		transform.position = new Vector3 (transform.position.x + moveHorizontal * Time.deltaTime, transform.position.y);

		//Vector3 movement = new Vector3 (-moveHorizontal, 0.0f, 0.0f);
//		
		//transform.position (movement);

		//Translate(movement * Time.deltaTime);

//		rb.position = new Vector3 
//			(
////				Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 
//				rb.position.x,
//				0.0f, 
//				rb.position.z
//			);
//
	}
}

