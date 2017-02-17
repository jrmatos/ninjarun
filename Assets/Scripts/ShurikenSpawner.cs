using UnityEngine;
using System.Collections;

public class ShurikenSpawner : MonoBehaviour {

	public GameObject EnemyPrefab;
	float maxSpawnRateInSeconds = 5f;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnEnemy", 1);

		//Increase spawn rate every 30 seconds
		InvokeRepeating("IncreaseSpawnRate",0f, 5f);
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

		if (maxSpawnRateInSeconds > 0.5f) {
			//pik a number between 1 and maxSpawnRateInSeconds
			spawnInNSeconds = Random.Range (0.5f, maxSpawnRateInSeconds);
		} else {
			spawnInNSeconds = 0.5f;
		}

		Invoke ("SpawnEnemy", spawnInNSeconds);
	}

	//Function to increase the dificulty of the game
	void IncreaseSpawnRate() {
		if (maxSpawnRateInSeconds > 0.5f)
			maxSpawnRateInSeconds--;
		if (maxSpawnRateInSeconds == 0.5f)
			CancelInvoke ("IncreaseSpawnRate");
	}
}
