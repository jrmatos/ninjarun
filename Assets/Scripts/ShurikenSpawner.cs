using UnityEngine;
using System.Collections;

public class ShurikenSpawner : MonoBehaviour {

	public GameObject EnemyPrefab;
	float maxSpawnRateInSeconds = 5f;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnEnemy", maxSpawnRateInSeconds);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Function to spawn an enemy
	void SpawnEnemy () {
		//Instantiate an enemy
		GameObject anEnemy = (GameObject)Instantiate (EnemyPrefab);
		anEnemy.transform.position = new Vector2 (10,Random.Range (-4,-2));

	}
}
