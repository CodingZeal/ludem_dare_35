using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject[] walls;
	public float spawnWait;
	public float startWait;
	public Vector2 spawnValues;
//	public int waveCount;
//	public float waveWait;
//	public Text scoreText;
//	public Text gameOverText;
//	public Text restartText;
//	private int score;

//	private bool gameOver;
//	private bool restart;

	void Start ()
	{
//		gameOver = false;
//		restart = false;
//		restartText.text = "";
//		gameOverText.text = "";
//
//		score = 0;
//		UpdateScore ();
		StartCoroutine (SpawnWalls ());
	}

	void Update() {
//		if (restart) {
//			if (Input.GetKeyDown (KeyCode.R)) {
//				Application.LoadLevel (Application.loadedLevel);
//			}
//		}
	}

	IEnumerator SpawnWalls ()
	{
		while(true) {
			yield return new WaitForSeconds (startWait);
//			for (int i = 0; i < hazardCount; i++) {
			Vector3 spawnPosition = new Vector3 (Random.Range (0 + -24, spawnValues.x + -24), spawnValues.y, -80.0f);
//			Quaternion spawnRotation = Quaternion.identity;
			GameObject wall = walls [Random.Range (0, walls.Length)];
			Quaternion spawnRotation = Quaternion.identity;

			Instantiate (wall, spawnPosition, spawnRotation);	
			yield return new WaitForSeconds (spawnWait);
//			}
//			yield return new WaitForSeconds (waveWait);
//			if (gameOver) {
//				restartText.text = "Press 'R' for Restart";
//				restart = true;
//				break;
//			}

		}

	}

//	void UpdateScore () {
//		scoreText.text = "Score: " + score;
//	}
//
//	public void GameOver(){
//		gameOverText.text = "Game Over";
//		gameOver = true;
//	}
//
//	public void AddScore(int newScoreValue){
//		score += newScoreValue;
//		UpdateScore ();
//	}
}
