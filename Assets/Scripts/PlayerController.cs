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
		float moveVertical = Input.GetAxis ("Vertical");

		Debug.Log ("Horizontal: " + moveHorizontal);
		Debug.Log ("Vertical: " + moveVertical);

		Vector3 movement = new Vector3 (-moveHorizontal, 0.0f, 0.0f);
//		rb.velocity = movement * speed;
		rb.transform.Translate(movement);

		Debug.Log ("position:" + rb.position);

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

