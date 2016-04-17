using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		other.gameObject.transform.position = new Vector3 (0, 1, 0);
	}
}
