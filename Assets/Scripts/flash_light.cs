using UnityEngine;
using System.Collections;

public class flash_light : MonoBehaviour {


	public Light lt;

	// Use this for initialization
	void Start () { 
		lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		var BPM = Engine.bpm;
		var minute = 6000;
		if (Time.time /100 % (minute / BPM) == 0) {
			lt.intensity = 8;
		} else {
			lt.intensity = 0;
		}
	}
}
