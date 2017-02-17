using UnityEngine;
using System.Collections;

public class ShurikenSpawner : MonoBehaviour {

	public GameObject EnemyPrefab;
	float maxSpawnRateInSeconds = 5f;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnEnemy", maxSpawnRateInSeconds);

		//Increase spawn rate every 30 seconds
		InvokeRepeating("IncreaseSpawnRate",0f,30f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Function to spawn an enemy
	void SpawnEnemy () {
		//Instantiate an enemy
		GameObject anEnemy = (GameObject)Instantiate (EnemyPrefab);
		anEnemy.transform.position = new Vector2 (10,Random.Range (-4,-2));

		//Schedule when to spawn next enemy
		ScheduleNextEnemy();

	}

	void ScheduleNextEnemy() {
		float spawnInNSeconds;

		if (maxSpawnRateInSeconds > 1f) {
			//pik a number between 1 and maxSpawnRateInSeconds
			spawnInNSeconds = Random.Range (1f, maxSpawnRateInSeconds);
		} else {
			spawnInNSeconds = 1f;
		}

		Invoke ("SpawnEnemy", spawnInNSeconds);
	}

	//Function to increase the dificulty of the game
	void IncreaseSpawnRate() {
		if (maxSpawnRateInSeconds > 1f)
			maxSpawnRateInSeconds--;
		if (maxSpawnRateInSeconds == 1f)
			CancelInvoke ("IncreaseSpawnRate");
	}
}
