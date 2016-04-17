using UnityEngine;
using System.Collections;

public class Crash : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		print (collision.gameObject);
	}
}
