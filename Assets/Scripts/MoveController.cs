using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

	public float speed = 10.0F;
	void Update() {
		float translation = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		transform.Translate (translation, 0, 0);
	}
}
