using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMorph : MonoBehaviour {

	public Mesh[] shapes;

	private int currentMeshIndex = 0;
	private int[] randomIndex;
	private Mesh currentMesh;
	private MeshFilter currentMeshFilter;

	void Start(){
		currentMeshFilter = GetComponent<MeshFilter> ();
		currentMesh = currentMeshFilter.mesh;
	}
		
	void Update () {
		if(Input.GetKeyDown("1")){
			currentMeshFilter.mesh = shapes [0];
		}
		if(Input.GetKeyDown("2")){
			currentMeshFilter.mesh = shapes [1];
		}
		if(Input.GetKeyDown("3")){
			currentMeshFilter.mesh = shapes [2];
		}
		if(Input.GetKeyDown("4")){
			currentMeshFilter.mesh = shapes [3];
		}
		if(Input.GetKeyDown("space")){
			int randomIndex = RandomExcept (0, shapes.Length, currentMeshIndex);
			currentMeshIndex = randomIndex;
			currentMeshFilter.mesh = shapes [randomIndex];
		}
	}

	public int RandomExcept ( int fromNr, int exclusiveToNr, int exceptNr ) {
		int randomNr = exceptNr;

		while ( randomNr == exceptNr ) {
			randomNr = Random.Range( fromNr, exclusiveToNr );
		}

		return randomNr;
	}
}
