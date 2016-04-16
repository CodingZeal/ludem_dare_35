using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		moveHorizontal *= speed * -1;

		transform.position = new Vector3 (transform.position.x + moveHorizontal * Time.deltaTime, transform.position.y);

	}
}

