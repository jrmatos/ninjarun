using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyScene : MonoBehaviour {
	
	float speed;

	void Start() {
		speed = 15f;
	}

	void Update() {
		//Get the enemy the current position
		Vector2 position = transform.position;

		//Compute the enemy new position
		position = new Vector2 (position.x - speed * Time.deltaTime, position.y);

		//Update the enemy position
		transform.position = position;

		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

		if (transform.position.x < min.x) {
			Manager.score++;
			Debug.Log("Score: " + Manager.score);
			Destroy (gameObject);
		}
	}
}
